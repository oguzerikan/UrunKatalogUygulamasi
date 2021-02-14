using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){ Name = "Kamera", Description = "Kamera Ürünleri" },
                new Category(){ Name = "Bilgisayar", Description = "Bilgisayar Ürünleri" },
                new Category(){ Name = "Elektronik", Description = "Elektronik Ürünleri" },
                new Category(){ Name = "Telefon", Description = "Telefon Ürünleri" },
                new Category(){ Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() { Name = "Sony Fdr-Ax33 4K Video Kamera", Description = "4K Ultra Hd (3840 X 2160) Çekim, Balanced Optical Steadyshot, 29.8 Mm Zeıss® Vario-Sonnar® T* Lens", Price = 5300, Stock = 250, IsApproved = true, CategoryId = 1, IsHome = true, Image = "1.jpg" },
                new Product() { Name = "Sony HDR-PJ410 Dahili Projektörlü Handycam Kamera", Description = "Sony HDR-PJ410 Dahili Projektörlü Handycam Kamera, Şarj Edilebilir Pil Paketi (NP-BX1), AC Mount, USB Bağlantısı Destek Kablosu", Price = 2500, Stock = 145, IsApproved = false, CategoryId = 1, IsHome = true, Image = "2.jpg" },
                new Product() { Name = "Dji Osmo Action 4K Aksiyon Kamerası", Description = "Dahili Hafıza =>Yok, Full HD Desteği => Var, Gece Görüş => Yok, Hareket Algılama => Yok, Su Geçirmezlik	=> 10 m", Price = 2500, Stock = 470, IsApproved = true, CategoryId = 1, IsHome = true, Image = "3.jpg" },
                new Product() { Name = "Thieye T5 Edge 4K Aksiyon Kamera", Description = "Arttırılabilir Hafıza => 64 GB'a kadar, Fotoğraf Çekimi	=> Var, Full HD Desteği	=> Var, Hareket Algılama => Yok, Su Geçirmezlik	=> 40 m", Price = 1490, Stock = 115, IsApproved = false, CategoryId = 1, Image = "4.jpg" },
                new Product() { Name = "Lenovo IdeaPad S145-15API AMD Ryzen 7 3700U 8GB 512GB SSD", Description = "Bellek Hızı => 2400 MHz, Ram (Sistem Belleği) => 8 GB, Cihaz Ağırlığı => 2 kg ve Altı, Ekran Kartı => AMD Radeon Vega 10", Price = 5300, Stock = 1350, IsApproved = true, CategoryId = 2, IsHome = true, Image = "5.jpg" },
                new Product() { Name = "Apple MacBook Air Intel Core i5 5350U 8GB 128GB SSD", Description = "İşlemci => 5350U, Ekran Kartı => Intel HD Graphics, Ram (Sistem Belleği) => 8 GB, İşletim Sistemi => macOS, İşlemci Tipi => Intel Core i5", Price = 7200, Stock = 110, IsApproved = false, CategoryId = 2, IsHome = true, Image = "6.jpg" },
                new Product() { Name = "TURBOX ATM900068 Intel i7 8GB Ram 2TB Hdd 4GB Ekran Kartı", Description = "Harddisk Kapasitesi => 2 TB, İşlemci Tipi => Intel Core i7, Ekran Kartı Tipi => Harici Ekran Kartı, Ekran Kartı Modeli => Nvidia Geforce GT730, SSD Kapasitesi => Yok", Price = 4000, Stock = 870, IsApproved = true, CategoryId = 2, Image = "7.jpg" },
                new Product() { Name = "İzoly N12x İ5-3470 3.60GHz 8GB 240SSD 500GB RX 550 4GB DDR5 21.5 Masaüstü Bilgisayar", Description = "Harddisk Kapasitesi => 500 GB, İşlemci Tipi => Intel Core i5, SSD Kapasitesi => Yok, Ekran Kartı Tipi => Orta Seviye Harici Ekran Kartlı, Ekran Kartı ModeliAMD Radeon RX 550", Price = 3650, Stock = 185, IsApproved = false, CategoryId = 2, Image = "8.jpg" },
                new Product() { Name = "Micro Usb To Type-C Dönüştürücü", Description = "Micro USB to Type-C Dönüştürücü Micro USB girişli USB kablonuzu bu adaptör sayesinde Type-C girişine dönüştürebilir, telefonunuzu şarj edebilirsiniz. Ayrıca telefonunuzun hafızasındaki verilere de ulaşabilirsini,belleğinizdeki fotoğrafları, videoları ya da dokümanları akıllı telefonunuza ya da tabletinize transfer edebilirsiniz. Ürün, Type-C girişine sahip tüm cihazlarınızla uyumludur. Tak çalıştır özelliğine sahip olduğu için herhangi bir kurulum ya da tanıtım yapmanız gerekmez. DTS Elektronik Garanti ve Güvencesi Altındadır.", Price = 24, Stock = 345, IsApproved = true, CategoryId = 3, Image = "9.jpg" },
                new Product() { Name = "Mobitell 2.4g Kablosuz Hd Görüntü Aktarıcı", Description = "Mobitell 2.4G Kablosuz HD Görüntü Aktarıcı ile ses ve video senkronizasyonunu kolayca elde etmek için telefon ekranını diğer ekran cihazlarına senkronize edebilir. HDMI ve AV çift çıkışlar, yansıtma dongle%27ın video ve sesi aynı anda çıkarmasını sağlar. Ayrıca, DLNA çevrimiçi itme fonksiyonu, videoyu parazitsiz senkronize ederken telefonun diğer işlevlerini çalıştırmanıza izin verir.", Price = 200, Stock = 80, IsApproved = false, CategoryId = 3, IsHome = true, Image = "10.jpg" },
                new Product() { Name = "Premier Prd 9431 Dvd Dıvx Player", Description = "DVD/DivX ( Mpeg 4 )/ VCD/ MP3/ CD / çalar, Full uzaktan kumanda, Dolby Digital ( AC-3 ) Dekoderi, 5. 1 kanal surround dijital çıkış, DVD/ DVD-R/VCD/S-VCD/CVD/MP3/CD/CD-R diskleriyle uyumlu disk çalma zamanı hafızası ile stop ettiğiniz yerden tekrar izlemeye başlama imkanı", Price = 190, Stock = 470, IsApproved = true, CategoryId = 3, IsHome = true, Image = "11.jpg" },
                new Product() { Name = "Next Kanky Full Hd 2019 Yeni Uydu Alıcı + Wifi Aparatı", Description = "Uydu Kanal Kapasitesi: 5.000, İşlemci Hızı: 600MHz, Flash Hafızası: 4MB, RAM Hafızası: 64MB, İşletim Sistemi: RTOS & Next", Price = 140, Stock = 85, IsApproved = false, CategoryId = 3, Image = "12.jpg" },
                new Product() { Name = "iPhone 11 256 GB", Description = "Ön (Selfie) Kamera => 12 MP, Dahili Hafıza => 256 GB, RAM Kapasitesi => 4 GB RAM, Kamera Çözünürlüğü => 12 MP + 12 MP, Ekran Boyutu => 6,1 inç", Price = 9300, Stock = 825, IsApproved = true, CategoryId = 4, IsHome = true, Image = "13.jpg" },
                new Product() { Name = "Samsung Galaxy Note 20 Ultra 256 GB", Description = "Ön (Selfie) Kamera => 10 MP, Dahili Hafıza => 256 GB, RAM Kapasitesi => 8 GB RAM, Kamera Çözünürlüğü => 108 MP + 12 MP + 12 MP, Ekran Boyutu => 6,9 inç", Price = 13000, Stock = 220, IsApproved = false, CategoryId = 4, IsHome = true, Image = "14.jpg" },
                new Product() { Name = "LG K41S 32 GB (LG Türkiye Garantili)", Description = "Dörtlü Kamera, Süper Geniş Açılı Kamera, Derinlik Kamerası, AI Kamera, Sinematik Görüntü Kalitesine Sahip Geniş Ekran", Price = 2600, Stock = 910, IsApproved = true, CategoryId = 4, Image = "15.jpg" },
                new Product() { Name = "Casper Via X20 Premium Mavi", Description = "Ön Kamera Çözünürlüğü => 25 MP, Hızlı Şarj Özelliği => Var, Çift Hatlı => Var, Hafıza Kartı Desteği => 512 GB, Bellek Kapasitesi => 6 GB", Price = 3500, Stock = 260, IsApproved = false, CategoryId = 4, Image = "16.jpg" },
                //new Product() { Name = "Altus Alk 471 Nx A++ 560 lt No Frost Buzdolabı", Description = "Dondurucu Özelliği => No Frost, Enerji Sınıfı => A++, Ürün Tipi => Kombi Tipi, Ses Seviyesi (dB) => 40, Yıllık Enerji Tüketimi (kWh) => 343", Price = 4100, Stock = 440, IsApproved = true, CategoryId = 5 },
                //new Product() { Name = "LG F4J6VYP0W A+++ 9 kg 1400 Devir Çamaşır Makinesi", Description = "Enerji Sınıfı => A+++, Maksimum Devir Hızı => 1400, Yıkama Kapasitesi => 9 kg, Kurutma Özelliği => Yok, Renk => Beyaz", Price = 4650, Stock = 170, IsApproved = false, CategoryId = 5 },
                //new Product() { Name = "SAMSUNG AR12TXHQBWK AR35 A++ 12000BTU İnverter Klima", Description = "Klima Türü => Split(Duvar Tipi), Marka => Samsung, Soğutma Kapasitesi => (Btu/h)12001-18000, Enerji Sınıfı => A++", Price = 3600, Stock = 715, IsApproved = true, CategoryId = 5 },
                //new Product() { Name = "Vestel SP 113-S Su Sebili Gri", Description = "Kontrol Sistemi => Mekanik, Bardak Aparatı => Var, Soğuk Su Tank Kapasitesi => 3 L, Cihaz Tipi => Alt Damacanalı, Musluk Sayısı => 3", Price = 1600, Stock = 265, IsApproved = false, CategoryId = 5 }
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}