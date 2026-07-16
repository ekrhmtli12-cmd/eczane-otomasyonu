# 💊 Eczane Otomasyonu ve Yönetim Sistemi

Bu proje, bir eczanenin günlük operasyonlarını (ilaç takibi, müşteri işlemleri, reçete kayıtları, çalışan vardiyaları ve satış süreçlerini) yönetmek amacıyla geliştirilmiş **C# Windows Forms (WinForms)** tabanlı bir masaüstü uygulaması ve **SQL Server** veri tabanı yönetim sistemidir.

Proje, hem yönetimsel raporlamaları hem de kritik stok/son kullanma tarihi uyarıları gibi otomasyon süreçlerini dinamik veri tabanı mimarisi (Trigger'lar, Stored Procedure'ler, View'lar) kullanarak çözmektedir.

---

## 🛠️ Kullanılan Teknolojiler

* **Geliştirme Ortamı:** Visual Studio 2022
* **Programlama Dili:** C# (.NET Framework / Windows Forms)
* **Veri Tabanı:** Microsoft SQL Server (Transact-SQL)
* **Veri Tabanı Bağlantısı:** ADO.NET 

---

## 💾 Veri Tabanı Mimarisi

Sistem, ilişkisel veri tabanı kurallarına (Normalization) uygun olarak tasarlanmış **17 ana ve log tablosundan** oluşmaktadır:

* **Çalışanlar & Vardiyalar:** Eczane personelinin yetkilendirilmesi (`Rol`) ve çalışma saatlerinin takibi.
* **Müşteriler, Doktorlar & Kurumlar:** Satış ve reçete süreçlerinin paydaşları.
* **İlaçlar, Kategoriler & İlaç Türleri:** Eczanedeki ilaçların barkod, fiyat ve etken madde detayları.
* **Stoklar & Sipariş Talepleri:** Son kullanma tarihi yaklaşan ve kritik stok seviyesinin altına düşen ilaçların yönetimi.
* **Satışlar & Satış Detayları:** Yapılan satışların ve kesilen reçeteli/reçetesiz ilaç faturalarının takibi.
* **Log Tabloları:** Fiyat değişimleri (`FiyatLog`) ve kritik stok seviyesi uyarıları (`KritikStokLog`) otomatik olarak kayıt altına alınır.

---

## ⚙️ Gelişmiş SQL Yetenekleri (Stored Procedures & Views)

Veri tabanı tarafında iş mantığını yönetmek ve performansı artırmak adına aşağıdaki yapılar kurulmuştur:

### 1. Stored Procedures (Saklı Yordamlar)
* **`sp_KullaniciGirisKontrol`:** Kullanıcı adı ve şifre bilgilerini doğrular; giriş başarılıysa personelin ad ve soyad bilgisini geriye çıktı (`OUTPUT`) olarak döner.
* **`sp_YeniIlacEkle`:** Eklenecek ilacın barkodunun sistemde benzersiz olup olmadığını kontrol eder. Eğer barkod mevcutsa hata fırlatır (`RAISERROR`), aksi takdirde ilacı güvenli bir şekilde kaydeder.

### 2. Views (Sanal Tablolar)
* **`vw_DetayliReceteRaporu`:** Reçete, müşteri, doktor ve kurum tablolarını birleştirerek eczacının reçete bilgilerini tek bir ekranda detaylıca raporlamasını sağlar.
* **`vw_TarihiYaklasanIlaclar`:** Son kullanma tarihine **6 ay veya daha az kalmış** ve stokta bulunan ilaçları, üretici firma bilgileriyle birlikte listeler.

---

## 🚀 Projenin Kurulumu ve Çalıştırılması

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

### 1. Veri Tabanının Kurulması
1. **Microsoft SQL Server Management Studio (SSMS)** uygulamasını açın.
2. Depoda bulunan **`veritabanıproje.sql`** dosyasını SSMS üzerinde açın ve **Execute (F5)** butonuna basarak veritabanı tablolarını, procedure'leri ve örnek verileri oluşturun.

### 2. Projenin Visual Studio'da Açılması
1. **`EczaneOtomasyonu1.sln`** dosyasına çift tıklayarak projeyi Visual Studio üzerinde başlatın.
2. Proje içerisindeki veri tabanı bağlantı dizesini (`Connection String`) kendi SQL Server bağlantı adresinize göre güncelleyin:
   ```csharp
   string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=EczaneVeriTabani;Integrated Security=True;";
