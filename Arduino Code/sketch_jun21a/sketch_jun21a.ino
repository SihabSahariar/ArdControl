//Sihab Sahariar- 12-06-2021
float humidity=0;
float temperature=0;
void setup() {
  Serial.begin(9600);
}

void loop() {
  humidity =random(100.00);
  Serial.print("H");
  Serial.println(humidity);
  temperature =random(100);
  Serial.print("T");
  Serial.println(temperature);
  delay(1000);
}
