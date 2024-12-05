int led1 = 8; // KIRMIZI LED için 8 numaralı pin
int led2 = 9; // YEŞİL LED için 9 numaralı pin

void setup() {
    pinMode(led1, OUTPUT); // led1 pini çıkış olarak ayarlandı
    pinMode(led2, OUTPUT); // led2 pini çıkış olarak ayarlandı
    Serial.begin(9600);    // Seri haberleşme 9600 baud hızı ile başlatıldı
}

void loop() {
    if (Serial.available() > 0) { // Seri portta veri varsa
        char command = Serial.read(); // Komutu oku

        // LED'leri kontrol et
        if (command == '1') {
            digitalWrite(led1, HIGH); // Kırmızı LED Aç
        } 
        if (command == '2') {
            digitalWrite(led1, LOW);  // Kırmızı LED Kapat
        } 
        if (command == '3') {
            digitalWrite(led2, HIGH); // Yeşil LED Aç
        } 
        if (command == '4') {
            digitalWrite(led2, LOW);  // Yeşil LED Kapat
        } 
     }
}