#include <WiFi.h>
#include <WiFiUdp.h>
#define SOUND_SPEED 0.034

float moisture,sensor_analog;
const int sensor_pin = 34;
const int trigPin = 18;
const int echoPin = 5;

const char* ssid = "P1";
const char* password = "11012002";
const char* udpAddress = "192.168.137.1";
const int udpPort = 1605; 

WiFiUDP udp;
long duration;
float distanceCm;
float mb,mt;

void setup() {
  Serial.begin(115200);
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT);
  pinMode(22,OUTPUT);digitalWrite(22, LOW);
  pinMode(23,OUTPUT);digitalWrite(23, LOW);
  pinMode(2,OUTPUT);digitalWrite(2, LOW);
  pinMode(4,OUTPUT);digitalWrite(4, LOW) ; 

  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }
  Serial.println("Connected to WiFi");
  udp.begin(udpPort);
}

void loop() {
    sensor_analog = analogRead(sensor_pin);
  moisture = ( 100 - ( (sensor_analog/4095.00) * 100 ) );
    digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration = pulseIn(echoPin, HIGH);
  
  // Calculate the distance
  distanceCm = duration * SOUND_SPEED/2;

  
  // gửi dữ liệu qua UDP
  if(moisture<=60){
    digitalWrite(22, HIGH);
    digitalWrite(4, HIGH);//may bom on
    mt=1;
    }else{
      digitalWrite(22, LOW);
      digitalWrite(4, LOW);//may bom off
      mt=0;
      }
  if(distanceCm>=100){
    digitalWrite(23, HIGH);
    digitalWrite(2, HIGH);//may tuoi cay on
    mb=1;
    }else{
      digitalWrite(23, LOW);
      digitalWrite(2, LOW);//may tuoi cay off
      mb=0;
      }   
  Serial.println(moisture);
  Serial.println(distanceCm);
  char buffer[256];
  sprintf(buffer, "%.1f,%.1f,%.1f,%.1f",moisture, distanceCm,mb,mt);
  udp.beginPacket(udpAddress, udpPort);
  udp.print(buffer);
  udp.endPacket();
  
  delay(1000); 
  
}
