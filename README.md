### **README - LedBlinking C# Arduino Project**

---

## **Amaç**
Bu proje, Arduino ve C# arayüzü kullanarak LED'lerin seri port üzerinden kontrolünü sağlar. Projenin ana hedefleri:
1. **Seri Haberleşme Protokolünü Öğrenmek:** Arduino ve C# arasında veri transferi yaparak seri haberleşmenin temelini kavramak.
2. **Donanım ve Yazılım Entegrasyonu:** Donanım bağlantılarını ve yazılım tabanlı kontrol mekanizmalarını deneyimlemek.
3. **Kullanıcı Dostu Bir Kontrol Paneli:** LED kontrolü için Visual Studio kullanarak kullanıcı dostu bir C# arayüzü geliştirmek.

---

## **İçerik**
Projede aşağıdaki özellikler ve araçlar kullanılmıştır:
- **Donanım:** 
  - Arduino Uno
  - 2 LED (Kırmızı ve Yeşil)
  - 220Ω Dirençler
  - Breadboard
  - Bağlantı Kabloları
- **Yazılım:**
  - Arduino IDE: Arduino'ya yüklemek için temel LED kontrol kodlarını yazmak.
  - Visual Studio: C# dilinde bir Windows Forms uygulaması geliştirmek.

---

## **Kurulum İçin İhtiyaç Duyulanlar**
1. **Arduino IDE Kurulumu:**
   - Arduino IDE'yi [buradan](https://www.arduino.cc/en/software) indirin ve bilgisayarınıza kurun.
   - Arduino Uno cihazınızı bilgisayara bağlayın ve uygun COM portunu seçin.
   - Arduino kodlarını yükleyin.
2. **Visual Studio Kurulumu:**
   - Visual Studio'yu [buradan](https://visualstudio.microsoft.com/downloads/) indirin.
   - Kurulum sırasında şu bileşenleri seçin:
     - `.Net Desktop Development`
     - `Data Storage and Processing`
3. **Proje Kurulumu:**
   - Visual Studio'da yeni bir Windows Forms App projesi oluşturun.
   - Proje adı verirken Türkçe karakter kullanmamaya dikkat edin.
   - LTS (Long Term Support) framework’ü seçin.

---

## **Arayüz Özellikleri**
Projede kullanılan C# arayüzü şu özelliklere sahiptir:
1. **COM Port Seçimi:**
   - Bağlı olan Arduino cihazınızın COM portunu seçebilmek için bir açılır liste (ComboBox).
2. **LED Kontrol Butonları:**
   - **RedOn:** Kırmızı LED'i açmak için bir buton.
   - **RedOff:** Kırmızı LED'i kapatmak için bir buton.
   - **GreenOn:** Yeşil LED'i açmak için bir buton.
   - **GreenOff:** Yeşil LED'i kapatmak için bir buton.
3. **Durum Geri Bildirimi:**
   - Kullanıcıya bağlantı durumu ve LED'in açık/kapalı durumu hakkında bilgi veren bir durum etiketi (`label`).

---

## **Devre Şeması ve Görseli**
Projede kullanılan devre aşağıdaki şekilde tasarlanmıştır:
1. **Kırmızı LED:**
   - Anot bacağı Arduino'nun D8 pinine bağlı.
   - Katot bacağı 220Ω direnç üzerinden GND'ye bağlanır.
2. **Yeşil LED:**
   - Anot bacağı Arduino'nun D9 pinine bağlı.
   - Katot bacağı 220Ω direnç üzerinden GND'ye bağlanır.
3. **Bağlantılar:**
   - Arduino, bilgisayara USB kablosu ile bağlanır.
   - Breadboard, LED'leri ve dirençleri birbirine bağlamak için kullanılır.

#### **Devre Görseli:**
![Devre Şeması](https://github.com/user-attachments/assets/951808c5-f4dc-4462-8462-5a895223e429)

