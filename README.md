# 🌟 Arduino ve C# ile LED Kontrolü 
## Amaç
Bu proje, Arduino ve C# arayüzü kullanarak LED'lerin seri port üzerinden kontrolünü sağlar. Projenin ana hedefleri:
1. **📡Seri Haberleşme Protokolünü Öğrenmek:** Arduino ve C# arasında veri transferi yaparak seri haberleşmenin temelini kavramak.
2. **Donanım ve Yazılım Entegrasyonu:** Donanım bağlantılarını ve yazılım tabanlı kontrol mekanizmalarını deneyimlemek.
3. **Kullanıcı Dostu Bir Kontrol Paneli:** LED kontrolü için Visual Studio kullanarak kullanıcı dostu bir C# arayüzü geliştirmek.
---
## İçerik
Projede aşağıdaki özellikler ve araçlar kullanılmıştır:
- Donanım:
  - Arduino Uno
  - 2 LED (Kırmızı ve Yeşil)
  - 220Ω Dirençler
  - Breadboard
  - Bağlantı Kabloları
- Yazılım:
  - Arduino IDE: Arduino'ya yüklemek için temel LED kontrol kodlarını yazmak.
  - Visual Studio: C# dilinde bir Windows Forms uygulaması geliştirmek.
--
## 🔧 Kurulum İçin İhtiyaç Duyulanlar
1. Arduino IDE Kurulumu:
   - Arduino IDE'yi [buradan](https://www.arduino.cc/en/software) indirin ve bilgisayarınıza kurun.
   - Arduino Uno cihazınızı bilgisayara bağlayın ve uygun COM portunu seçin.
   - Arduino kodlarını yükleyin.
2. Visual Studio Kurulumu:
   - Visual Studio'yu [buradan](https://visualstudio.microsoft.com/downloads/) indirin.
   - Kurulum sırasında şu bileşenleri seçin:
     - `.Net Desktop Development`
     - `Data Storage and Processing`
3. Proje Kurulumu:
   - Visual Studio'da yeni bir Windows Forms App(.Net Framework) projesi oluşturun.
   - Proje adı verirken Türkçe karakter kullanmamaya dikkat edin.
   - LTS (Long Term Support) framework’ü seçin.
  
- https://www.youtube.com/watch?v=liKyYxO29GE bu videoyu kullanıp kurulum yapabilirsiniz ancak hocanın windows forms app kullanmış olduğunu göreceksiniz. Ancak bunu kullanınca "Serial Port" kullanamıyor olduğunuzu unutmayın, Tool boxta yok !..

### ⚡ Devre Şeması ve Görseli 
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
### Devre Görseli:
![Devre Şeması](https://github.com/user-attachments/assets/951808c5-f4dc-4462-8462-5a895223e429)

### Devre Şeması:
![Devre Şeması](https://github.com/user-attachments/assets/9d59806b-51db-40e1-8381-89ed14ba55b2)

### C# Windows Forms Uygulaması:
![Screenshot 2024-12-05 191137](https://github.com/user-attachments/assets/92dae0aa-5278-4dd2-964e-b3758c047ffd)

https://github.com/user-attachments/assets/ffd41510-a322-4395-928c-a0bd7e168767

---
## Arayüz Özellikleri
Projede kullanılan C# arayüzü şu özelliklere sahiptir:
1. LED Kontrol Butonları:
   - **RedOn:** Kırmızı LED'i açmak için bir buton.
   - **RedOff:** Kırmızı LED'i kapatmak için bir buton.
   - **GreenOn:** Yeşil LED'i açmak için bir buton.
   - **GreenOff:** Yeşil LED'i kapatmak için bir buton.
2. **Durum Geri Bildirimi:**
   - Kullanıcıya bağlantı durumu ve LED'in açık/kapalı durumu hakkında bilgi veren bir durum etiketi (`label`).
---
### 🔌COM Port Tanımlama ve Kullanımı
---
## COM Port Tanımlama ve Kullanımı
### Port Tanımlaması
```csharp
arduinoPort = new SerialPort
{
    PortName = "COM5",
    BaudRate = 9600
};
```
Bu kod, **`SerialPort`** sınıfının bir örneğini (`arduinoPort`) oluşturur ve port özelliklerini manuel olarak ayarlar:
- **`PortName:`** Arduino'nun bağlı olduğu COM port adını belirtir (örneğin, `COM5`). Bu adı manuel olarak belirtiyoruz.
- **`BaudRate:`** Veri iletişim hızını ayarlar. Arduino kodunda `Serial.begin(9600)` olarak tanımlandığı için burada da `9600` seçilmiştir.

---
### **Portu Açma**
```csharp
arduinoPort.Open();
```

Bu kod, belirtilen COM portu üzerinden bağlantıyı başlatır:
- Port açık değilse, bağlantı kurulur.
- Eğer port zaten kullanılıyorsa veya geçersiz bir port adı atanmışsa, bir hata fırlatılır.

#### sonuç olarak bu şekilde kullandım:
```csharp
 public partial class Form1 : Form
    {
        SerialPort arduinoPort;
        public Form1()
        {
            InitializeComponent();
            arduinoPort = new SerialPort
            {
                PortName = "COM5",
                BaudRate = 9600
            };

            arduinoPort.Open();
        }
```

💡 Ekstra İpuçları
COM Port Sorunu: Eğer port tanınmıyorsa, "Aygıt Yöneticisi" üzerinden COM portu kontrol edin.
---
## **Manuel Port Tanımlamanın Avantajları**

1. **Hızlı ve Statik Kullanım:**
   - Belirli bir port adı biliniyorsa (`COM5` gibi), kullanıcıya port seçme veya giriş yapma gereksinimi bırakmaz.
   - Tek bir cihazla çalışan projeler için uygun ve basit bir çözümdür.

2. **Basitlik:**
   - Kullanıcıya port seçimi sunulmaz, bu da kodu ve arayüzü daha sade hale getirir.
   - Port adı, doğrudan kod içerisinde sabitlenir ve bu sayede basit projeler için ideal bir yapı sağlar.

3. **Hata Yönetimi Kolaylığı:**
   - Port yanlış tanımlanırsa ya da port zaten kullanılıyorsa, bu durumu kod içerisinde ele alabilirsiniz.
   - **Hata Yönetimi Örneği:**
     ```csharp
     try
     {
         arduinoPort.Open();
         Console.WriteLine("Bağlantı başarılı!");
     }
     catch (UnauthorizedAccessException)
     {
         Console.WriteLine("Seçilen port başka bir uygulama tarafından kullanılıyor.");
     }
     catch (IOException)
     {
         Console.WriteLine("Port mevcut değil veya bağlantı kurulamadı.");
     }
     catch (Exception ex)
     {
         Console.WriteLine($"Bağlantı hatası: {ex.Message}");
     }
     ```
---

### Yaparken karşılaştığım hatalar : 
##### 1. Yazılımsal : COM portunun manual olarak set etmemesinden kaynaklı string array olarak alınması
![Screenshot 2024-12-06 at 1 25 47 am](https://github.com/user-attachments/assets/ab3e012f-c216-4a64-ba21-403fac513905)
##### 2. Donanımsal : devreyi yanlış bağlamak ve bu yüzden kırmızı yanarken yeşil yanmıyor aksine kırmızının sönmesine neden oluyordu.

### Donanım Bağlantısını Kontrol Etmek için:
##### 1.Bağlantıları Doğrulayın:
Arduino'yu bilgisayara doğru şekilde bağladığınızdan emin olun. USB kablonuzun çalıştığını kontrol edin.
Arduino'nun üzerindeki "ON" ve "TX/RX" LED'lerinin yanıp yanmadığını kontrol edin.
##### 2.Bağlı Portu Doğru Tanımlamak için:
Yanlış COM portu kullanıyor olabilirsiniz. Doğru portu bulmak için şu adımları izleyin:
Windows'ta: Aygıt Yöneticisi'ni açın (Başlat > Aygıt Yöneticisi).
"Bağlantı Noktaları (COM ve LPT)" sekmesine tıklayın.
Arduino'nuzun hangi portta olduğunu görün (örneğin, COM7 yerine COM5 olabilir).
