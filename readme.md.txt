Form uygulaması içinde çalışan temel bir oyundur.
Değişkenler;
Yılan: Yılanın vücut parçaları point tipinde koordinatlar.
Yem: Yemin koordinatı.
Yon: Yılanın yönü (0:yukarı,1:aşağı,2sol,3:sağ)
Kareboyutu: Yılan ve yemin bir karesinin piksel boyu
OyunZamanı: Her 100 ms'de bir oyunu günceller.
Oyunbitti: Oyun bitince güncellemeleri durdurur.
Rastgele: Yeni yem için rastgele bir sayı üretir.

Kurucu Metot;

public YılanOyunu()

Formun genişliği ve yüksekliği ayarlanıyor.
DoubleBuffered ekran titreşimini engelliyor.
KeyDown klavye hareketlerini yakalıyor.
Timer oluşturuluyor ve OyunGuncelle ile her tick'te metod tekrar çağırılıyor.
OyunuBaslat() ile oyun başlatılıyor.

private void OyunuBaslat()

Yılan sıfırlanıyor ve başlangıç noktası (10,10) atanıyor.
İlk yem oluşturuluyor (YemOlustur()).
Yön sağa (3) olarak ayarlanıyor.
Zamanlayıcı başlatılıyor.

private void YemOlustur()

Rastgele bir Point belirlenir (formun içindeki uygun koordinatlarda).
Yem rastgele bir noktada belirir.

private void OyunuGuncelle(object sender, EventArgs e)

Oyun bittiyse: Güncellemeyi durdurur.
Yeni baş (baş kısmı) oluşturur: Geçerli yöne göre yılan[0] (baş) noktasını değiştirir.
Yılan duvara çarparsa veya kendine çarparsa → oyunBitti = true.

Eğer yeni baş yemi yediyse: Yem yeniden oluşturulur, yılan uzar.
Aksi halde: Kuyruktaki son parça silinir (yılan hareket eder ama uzamaz).

Ekran yeniden çizdirilir (Invalidate() → OnPaint() çağrılır).

private void TusBasıldı(object sender, KeyEventArgs e)

Yön tuşlarına göre yon değişkeni değiştirilir.
Aynı anda ters yönde gitmeyi engeller (örnek: yukarı giderken aşağı dönemezsin).

protected override void OnPaint(PaintEventArgs e)

Yılan parçaları yeşil olarak çizilir (FillRectangle ile).
Yem kırmızı olarak çizilir.
















