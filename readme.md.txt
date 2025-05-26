# 🐍 Yılan Oyunu (Snake Game) - Windows Forms

Bu proje, klasik Yılan Oyunu'nun (Snake Game) C# dili kullanılarak Windows Forms üzerinde gerçekleştirilmiş basit bir sürümüdür. Oyuncu, yılanı yön tuşları ile yönlendirerek yemleri yemeye çalışır. Her yem yendiğinde yılan uzar. Duvara çarparsa veya kendine değerse oyun sona erer.

## 🎮 Oyun Kuralları

- Yılan yukarı, aşağı, sola veya sağa hareket edebilir.
- Yılan bir yem yediğinde uzar.
- Yılan duvara çarparsa veya kendi vücuduna değerse oyun biter.
- Oyun ekranı 400x400 pikseldir ve kareler 20x20 piksel boyutundadır.

## 🚀 Başlangıç

Proje bir Windows Forms uygulamasıdır. Visual Studio ile açıp `F5` tuşuna basarak başlatabilirsiniz.

### Gereksinimler

- .NET Framework veya .NET Core/5+ ile uyumlu Visual Studio
- C# Windows Forms projesi

## 🧠 Kodun Açıklaması

### Ana Sınıf: `YılanOyunu : Form`

#### Değişkenler

- `List<Point> yılan`: Yılanın her parçasını temsil eden noktaların listesi.
- `Point yem`: Mevcut yem pozisyonu.
- `int yon`: Yılanın yönü (0:Yukarı, 1:Aşağı, 2:Sol, 3:Sağ).
- `int kareboyutu`: Oyun alanındaki her bir karenin piksel boyutu.
- `Timer oyunZamanı`: Oyun güncellemelerini kontrol eden zamanlayıcı.
- `bool oyunBitti`: Oyun bitip bitmediğini belirten bayrak.
- `Random rastgele`: Rastgele yem üretimi için kullanılır.

#### Yapıcı Metot: `YılanOyunu()`

- Formun boyutlarını ayarlar.
- `DoubleBuffered` ile flicker'ı azaltır.
- Klavye tuşlarına tepki vermek için `KeyDown` olayını tanımlar.
- Zamanlayıcıyı oluşturur ve güncelleme olayına bağlar.
- Oyunu başlatır.

#### Metotlar

- `OyunuBaslat()`: Yılanı ve ilk yemi başlatır. Yönü sağ olarak ayarlar ve zamanlayıcıyı başlatır.
- `YemOlustur()`: Ekran sınırları içinde rastgele bir yem noktası üretir.
- `OyunuGuncelle(object sender, EventArgs e)`: 
  - Yılanın başını yeni yöne göre hareket ettirir.
  - Duvar ya da kendine çarpma durumunda oyunu bitirir.
  - Yem yendiyse yılanı uzatır, aksi takdirde son parçayı siler.
  - Formu yeniden çizer.
- `TusBasıldı(object sender, KeyEventArgs e)`: Yön tuşlarına basıldığında yön değişimini yönetir.
- `OnPaint(PaintEventArgs e)`: Yılanın ve yemin çizimini yapar.

## 🎨 Grafikler

- Yılan: `DarkOliveGreen` renkte çizilir.
- Yem: `Red` renkte kare olarak çizilir.

## 🛠️ Geliştirme Önerileri

- Skor sistemi eklenebilir.
- Durdur/Devam ettir özelliği eklenebilir.
- Seviyeler ya da zorluk dereceleri eklenebilir.
- Daha iyi görsel efektler ve sesler entegre edilebilir.

## 📷 Ekran Görüntüsü

*(Henüz eklenmedi)*

## 📄 Lisans

Bu proje eğitim amaçlıdır ve kişisel kullanım için serbestçe kullanılabilir.
