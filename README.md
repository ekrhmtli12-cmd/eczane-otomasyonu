# 🖥️ C# WinForms Eczane Otomasyonu (Access DB)

Bu proje, bir eczanenin günlük ilaç kayıtlarını, satış süreçlerini ve stok takibini gerçekleştirmek amacıyla **C# Windows Forms** ve **Microsoft Access (.accdb)** veri tabanı kullanılarak geliştirilmiş masaüstü otomasyon uygulamasıdır.

Uygulama, tamamen görsel arayüzler üzerinden veri ekleme, silme, güncelleme ve listeleme (CRUD) işlemlerini kolayca yapmayı sağlar.

---

## 🛠️ Kullanılan Teknolojiler

* **Geliştirme Ortamı:** Visual Studio 2022
* **Programlama Dili:** C# (.NET Framework)
* **Arayüz:** Windows Forms (WinForms)
* **Veri Tabanı:** Microsoft Access Database (`eczanetomasyonu.accdb`)
* **Bağlantı Teknolojisi:** OleDb (OLE DB Provider)

---

## ⚙️ Uygulama Özellikleri

* **İlaç Kayıt ve Yönetimi:** Sisteme yeni ilaçlar ekleme, mevcut ilaç bilgilerini güncelleme ve artık satılmayan ilaçları silme.
* **Hızlı Listeleme:** Veri tabanındaki tüm ilaçların ve stok durumlarının `DataGridView` üzerinde anlık olarak listelenmesi.
* **Access Veri Tabanı Entegrasyonu:** Verilerin yerel bir `.accdb` dosyasında güvenli ve taşınabilir bir şekilde saklanması.

---

## 📥 Kurulum ve Çalıştırma Adımları

Uygulamayı kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. Bu depoyu bilgisayarınıza indirin (ZIP olarak indirebilir veya kopyalayabilirsiniz).
2. Klasörün içindeki **`EczaneOtomasyonu1.sln`** dosyasına çift tıklayarak projeyi **Visual Studio 2022** üzerinde açın.
3. Proje klasöründeki `eczanetomasyonu.accdb` veri tabanı dosyasının yolunu (Connection String), kendi bilgisayarınızdaki dosya yoluna göre kod içerisinden güncelleyin.
4. Visual Studio üst menüsünden **Start (F5)** butonuna basarak uygulamayı çalıştırın.
