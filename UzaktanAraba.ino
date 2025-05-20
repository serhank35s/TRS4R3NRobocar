#define motor1 A0
#define motor2 A3
#define motor3 A1
#define motor4 A2

int hiz_degeri;
int bluetooth_sinyal;
const int hcsr04_echo=3,hcsr04_triq=2;
long sure,uzaklik;
void setup()
{
 pinMode(A0,OUTPUT); //IN3
 pinMode(A1,OUTPUT); //IN1
 pinMode(A2,OUTPUT); //IN2
 pinMode(A3,OUTPUT); //IN4
 pinMode(hcsr04_triq,OUTPUT);
 pinMode(hcsr04_echo,INPUT);
 Serial.begin(9600);
}
void loop()
{
  digitalWrite(hcsr04_triq,LOW);
  delayMicroseconds(5);
  digitalWrite(hcsr04_triq,HIGH);
  delayMicroseconds(10);
  digitalWrite(hcsr04_triq,LOW);
  sure=pulseIn(hcsr04_echo,HIGH);
  uzaklik=sure/29.1/2;
  if(Serial.available())
  {
    bluetooth_sinyal=Serial.read(); 
  }
  else
  {
  analogWrite(motor1,0);
  analogWrite(motor2,0);
  analogWrite(motor3,0);
  analogWrite(motor4,0);
  }
  //analogWrite(A0,255); Sağ Tekerlekler(Geri) motor1
  //analogWrite(A2,255); Sol Tekerlekler(Geri) motor4
  //analogWrite(A1,255); Sol Tekerlekler(İleri) motor3
  //analogWrite(A3,255); Sağ Tekerlekler(İleri) motor2
   switch(bluetooth_sinyal)
    {
      case 'W':
      {
      analogWrite(motor2,hiz_degeri);
      analogWrite(motor1,0);
      analogWrite(motor3,hiz_degeri);
      analogWrite(motor4,0);
        break;
      }
      case 'S':
      {
       analogWrite(motor1,hiz_degeri);
       analogWrite(motor2,0);
       analogWrite(motor3,0);
       analogWrite(motor4,hiz_degeri);
        break;
      }
      case 'A':
      {
       analogWrite(motor1,0);
       analogWrite(motor2,100);
       analogWrite(motor3,0);
       analogWrite(motor4,hiz_degeri);
        break;
      }
      case 'D':
      {
       analogWrite(motor1,0);
       analogWrite(motor2,hiz_degeri);
       analogWrite(motor3,0);
       analogWrite(motor4,0);
        break;
      }
      case 'd':
      {
       analogWrite(motor1,0);
       analogWrite(motor2,0);
       analogWrite(motor3,0);
       analogWrite(motor4,0);
       break;
      }
      case 'E':
      {
        analogWrite(motor1,0);
        analogWrite(motor2,100);
        analogWrite(motor3,0);
        analogWrite(motor4,hiz_degeri);
      }
      case 'Q':
      {
        analogWrite(motor1,0);
        analogWrite(motor2,hiz_degeri);
        analogWrite(motor3,0);
        analogWrite(motor4,100);
      }
      case 'C':
      {
        analogWrite(motor1,hiz_degeri);
        analogWrite(motor2,0);
        analogWrite(motor3,0);
        analogWrite(motor4,100);
      }
      case 'Z':
      {
        analogWrite(motor1,100);
        analogWrite(motor2,0);
        analogWrite(motor3,0);
        analogWrite(motor4,hiz_degeri);
      }
      case 'a':
      {
        hiz_degeri=51;
      }
     case 'b':
      {
        hiz_degeri=102;
      }
     case 'c':
      {
        hiz_degeri=153;
      }
      case 'e':
      {
        hiz_degeri=204;
      }
      case 'f':
      {
        hiz_degeri=255;
      }
    } 
  if(uzaklik<50)
  {
    analogWrite(motor1,255);
    analogWrite(motor2,0);
    analogWrite(motor3,0);
    analogWrite(motor4,255);
  }
}
