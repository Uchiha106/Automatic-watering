using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace pr01
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        string InputData = String.Empty;
        string InputDataTime = String.Empty;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGVAG2B;Initial Catalog=DNLam;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        static int i = 1;
        int rowIndex = 0;

        private void KetNoiCSDL()
        {
            
            string sql = "select * from Table_pr02";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }
        

        private void Refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM Table_pr02", con);
            cmd.ExecuteNonQuery();
            KetNoiCSDL();
            i = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dNLamDataSet4.Table_pr02' table. You can move, or remove it, as needed.
            this.table_pr02TableAdapter3.Fill(this.dNLamDataSet4.Table_pr02);
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.CurrentCell.RowIndex;
            Soil.Text = dataGridView1["SoilDataGridViewTextBoxColumn", rowIndex].Value.ToString();
            Water.Text = dataGridView1["WaterDataGridViewTextBoxColumn", rowIndex].Value.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            KetNoiCSDL();
            
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                
                i = Int32.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                i++;
            }
            else i = 1;
            timer1.Start();
        }
        private delegate void dlgAutoUpdateDatabases(long ID, string soil, string water,string time);

        private void AutoUpdateDatabases(long ID, string soil, string water,string time)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabases), ID, soil,water,time);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Table_pr02 (ID,Water,Soil,Time) VALUES (@ID,@Water,@Soil,@Time)", con);
                
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Soil", soil);
                cmd.Parameters.AddWithValue("@Water", water);
                cmd.Parameters.AddWithValue("@Time", time);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    return;
                }
                KetNoiCSDL();
            }
        }
        int Step = 1000;


        private float soilmoisture, ultrasonic, mb, mt;
        public void serverThread() 
        {
            UdpClient udpClient = new UdpClient(1605);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse("192.168.137.1"), 1605);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string[] values = returnData.Split(',');
                soilmoisture = float.Parse(values[0]);
                ultrasonic = float.Parse(values[1]);
                mb = float.Parse(values[2]);
                mt = float.Parse(values[3]);

                InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                AutoUpdateDatabases(i, values[0], values[1], InputDataTime);
                i++;

                this.BeginInvoke(new MethodInvoker(delegate
                {
                    if (mb == 0)
                    {
                        pump.Text = ("OFF");
                        pump.ForeColor = Color.Green;
                    }
                    else
                    {
                        pump.Text = ("ON");
                        pump.ForeColor = Color.Red;
                    }

                    
                    if (mt == 0)
                    {
                        valve.Text = ("OFF");
                        valve.ForeColor = Color.Green;
                    }
                    else
                    {
                        valve.Text = ("ON");
                        valve.ForeColor = Color.Red;
                    }

                    Soil.Text = soilmoisture.ToString() + " %";
                    Water.Text = ultrasonic.ToString() + " cm";

                }));

                Thread.Sleep(Step);
            }
        }

        }

    }

