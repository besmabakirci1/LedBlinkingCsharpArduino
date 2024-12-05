## LedBlinking C# Arduino
#### C# arayüzü üzerinden Arduino'ya komut göndererek LED'leri kontrol etmek.
#### Seri port üzerinden veri transferi ve haberleşme protokolünü anlamak.

### Proje İçeriği:
- **Donanım:** Arduino Uno, 2 LED (Kırmızı ve Yeşil), 220Ω dirençler, breadboard.
- **Arduino Kodu:** Seri port üzerinden gelen '1' ve '0' komutlarıyla LED'leri kontrol eder.
- **C# Arayüzü:** COM port seçimi yapılarak LED'leri aç/kapat komutları gönderilir.
### C# Arayüzü - LED Kontrol Paneli
##### Bu arayüz, Arduino üzerindeki LED'leri seri port üzerinden kontrol etmek için tasarlanmıştır. Kullanıcı, butonları kullanarak kırmızı ve yeşil LED'leri açıp kapatabilir. Ayrıca, duruma ilişkin geri bildirim arayüzde gösterilir.

### Arayüz Özellikleri:
#### Dört Buton:
##### RedOn: Kırmızı LED'i açar.
##### RedOff: Kırmızı LED'i kapatır.
##### GreenOn: Yeşil LED'i açar.
##### GreenOff: Yeşil LED'i kapatır.
##### Durum Bilgisi: "Durum bilgisi bekleniyor" kısmı, LED'lerin aktif durumunu (örneğin, açık/kapalı) göstermek için kullanılabilir.
##### SerialPort: Seri port üzerinden Arduino ile iletişim kurar.

### Devre Görseli:
##### ![Devre Görseli](https://github.com/user-attachments/assets/951808c5-f4dc-4462-8462-5a895223e429)
### Arayuz Görseli 
##### ![Temel Arayuz Görseli](https://github.com/user-attachments/assets/8a5e89f7-f15e-4a9d-a659-792cc6fa9764)
