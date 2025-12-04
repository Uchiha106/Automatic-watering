namespace pr01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablepr01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dNLamDataSet = new pr01.DNLamDataSet();
            this.Refresh = new System.Windows.Forms.Button();
            this.Soil = new System.Windows.Forms.TextBox();
            this.Water = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.getTime = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.table_pr01TableAdapter = new pr01.DNLamDataSetTableAdapters.Table_pr01TableAdapter();
            this.pump = new System.Windows.Forms.TextBox();
            this.valve = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dNLamDataSet1 = new pr01.DNLamDataSet1();
            this.tablepr02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_pr02TableAdapter = new pr01.DNLamDataSet1TableAdapters.Table_pr02TableAdapter();
            this.dNLamDataSet2 = new pr01.DNLamDataSet2();
            this.tablepr02BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_pr02TableAdapter1 = new pr01.DNLamDataSet2TableAdapters.Table_pr02TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablepr02BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dNLamDataSet4 = new pr01.DNLamDataSet4();
            this.tablepr02BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dNLamDataSet3 = new pr01.DNLamDataSet3();
            this.table_pr02TableAdapter2 = new pr01.DNLamDataSet3TableAdapters.Table_pr02TableAdapter();
            this.table_pr02TableAdapter3 = new pr01.DNLamDataSet4TableAdapters.Table_pr02TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tablepr01BindingSource
            // 
            this.tablepr01BindingSource.DataMember = "Table_pr01";
            this.tablepr01BindingSource.DataSource = this.dNLamDataSet;
            // 
            // dNLamDataSet
            // 
            this.dNLamDataSet.DataSetName = "DNLamDataSet";
            this.dNLamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(499, 25);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(100, 29);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Soil
            // 
            this.Soil.Location = new System.Drawing.Point(123, 63);
            this.Soil.Name = "Soil";
            this.Soil.Size = new System.Drawing.Size(100, 22);
            this.Soil.TabIndex = 7;
            // 
            // Water
            // 
            this.Water.Location = new System.Drawing.Point(123, 94);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(100, 22);
            this.Water.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "192.168.2.21";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(499, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "1605";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soil_Moisture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Water_Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Port";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.SystemColors.Window;
            this.Timer.Location = new System.Drawing.Point(9, 26);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(42, 16);
            this.Timer.TabIndex = 15;
            this.Timer.Text = "Timer";
            // 
            // getTime
            // 
            this.getTime.Location = new System.Drawing.Point(123, 26);
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(304, 22);
            this.getTime.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // table_pr01TableAdapter
            // 
            this.table_pr01TableAdapter.ClearBeforeFill = true;
            // 
            // pump
            // 
            this.pump.Location = new System.Drawing.Point(337, 92);
            this.pump.Name = "pump";
            this.pump.Size = new System.Drawing.Size(100, 22);
            this.pump.TabIndex = 17;
            // 
            // valve
            // 
            this.valve.Location = new System.Drawing.Point(337, 63);
            this.valve.Name = "valve";
            this.valve.Size = new System.Drawing.Size(100, 22);
            this.valve.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Water_Valve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Water_Pump";
            // 
            // dNLamDataSet1
            // 
            this.dNLamDataSet1.DataSetName = "DNLamDataSet1";
            this.dNLamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablepr02BindingSource
            // 
            this.tablepr02BindingSource.DataMember = "Table_pr02";
            this.tablepr02BindingSource.DataSource = this.dNLamDataSet1;
            // 
            // table_pr02TableAdapter
            // 
            this.table_pr02TableAdapter.ClearBeforeFill = true;
            // 
            // dNLamDataSet2
            // 
            this.dNLamDataSet2.DataSetName = "DNLamDataSet2";
            this.dNLamDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablepr02BindingSource1
            // 
            this.tablepr02BindingSource1.DataMember = "Table_pr02";
            this.tablepr02BindingSource1.DataSource = this.dNLamDataSet2;
            // 
            // table_pr02TableAdapter1
            // 
            this.table_pr02TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.waterDataGridViewTextBoxColumn,
            this.soilDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablepr02BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(6, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 177);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 75;
            // 
            // waterDataGridViewTextBoxColumn
            // 
            this.waterDataGridViewTextBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewTextBoxColumn.HeaderText = "Water";
            this.waterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waterDataGridViewTextBoxColumn.Name = "waterDataGridViewTextBoxColumn";
            this.waterDataGridViewTextBoxColumn.Width = 75;
            // 
            // soilDataGridViewTextBoxColumn
            // 
            this.soilDataGridViewTextBoxColumn.DataPropertyName = "Soil";
            this.soilDataGridViewTextBoxColumn.HeaderText = "Soil";
            this.soilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soilDataGridViewTextBoxColumn.Name = "soilDataGridViewTextBoxColumn";
            this.soilDataGridViewTextBoxColumn.Width = 75;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // tablepr02BindingSource3
            // 
            this.tablepr02BindingSource3.DataMember = "Table_pr02";
            this.tablepr02BindingSource3.DataSource = this.dNLamDataSet4;
            // 
            // dNLamDataSet4
            // 
            this.dNLamDataSet4.DataSetName = "DNLamDataSet4";
            this.dNLamDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablepr02BindingSource2
            // 
            this.tablepr02BindingSource2.DataMember = "Table_pr02";
            this.tablepr02BindingSource2.DataSource = this.dNLamDataSet3;
            // 
            // dNLamDataSet3
            // 
            this.dNLamDataSet3.DataSetName = "DNLamDataSet3";
            this.dNLamDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_pr02TableAdapter2
            // 
            this.table_pr02TableAdapter2.ClearBeforeFill = true;
            // 
            // table_pr02TableAdapter3
            // 
            this.table_pr02TableAdapter3.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valve);
            this.Controls.Add(this.pump);
            this.Controls.Add(this.getTime);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.Soil);
            this.Controls.Add(this.Refresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablepr01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepr02BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNLamDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox Soil;
        private System.Windows.Forms.TextBox Water;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer timer1;
        private DNLamDataSet dNLamDataSet;
        private System.Windows.Forms.BindingSource tablepr01BindingSource;
        private DNLamDataSetTableAdapters.Table_pr01TableAdapter table_pr01TableAdapter;
        private System.Windows.Forms.TextBox pump;
        private System.Windows.Forms.TextBox valve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DNLamDataSet1 dNLamDataSet1;
        private System.Windows.Forms.BindingSource tablepr02BindingSource;
        private DNLamDataSet1TableAdapters.Table_pr02TableAdapter table_pr02TableAdapter;
        private DNLamDataSet2 dNLamDataSet2;
        private System.Windows.Forms.BindingSource tablepr02BindingSource1;
        private DNLamDataSet2TableAdapters.Table_pr02TableAdapter table_pr02TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DNLamDataSet3 dNLamDataSet3;
        private System.Windows.Forms.BindingSource tablepr02BindingSource2;
        private DNLamDataSet3TableAdapters.Table_pr02TableAdapter table_pr02TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DNLamDataSet4 dNLamDataSet4;
        private System.Windows.Forms.BindingSource tablepr02BindingSource3;
        private DNLamDataSet4TableAdapters.Table_pr02TableAdapter table_pr02TableAdapter3;
    }
}

