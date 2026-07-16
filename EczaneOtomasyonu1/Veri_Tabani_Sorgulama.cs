using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneOtomasyonu1
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;

    namespace Eczane_Otomasyonu_Yeni
    {
        class Veri_Tabanı_Sorgulama
        {
            public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = eczaneotomasyonu.mdb");

            public OleDbDataReader sorgula(string sorgu_yada_tabloadı, bool hepsimi)
            {
                OleDbCommand komut = null;
                OleDbDataReader oku = null;
                string sorgu;
                if (hepsimi)
                {
                    sorgu = "SELECT * FROM " + sorgu_yada_tabloadı;
                }
                else
                {
                    sorgu = sorgu_yada_tabloadı;
                }
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                komut = new OleDbCommand(sorgu, baglan);
                oku = komut.ExecuteReader();

                return oku;
            }
            public void ekle_müşteri_bilgileri(string KULLANICI_ADI, string KULLANICI_SOYADI, string KULLANICI_TELEFON_NUMARASI, string KULLANICI_ADRESİ, string BAĞLI_OLDUĞU_KURUM, string KAYIT_TARİHİ, string TC_KİMLİK_NO)

            {
                if (baglan.State == System.Data.ConnectionState.Closed) baglan.Open();

                string sorgu = "INSERT INTO MUSTERİ_BİLGİLERİ (kullanıcı_adı, kullanıcı_soyadı, tc, kullanıcı_telefon_no, adres, bağlı_olduğu_kurum) " +
                               "VALUES (@ad, @soyad, @tc, @telefon, @adres, @kurum)";

                OleDbCommand komut = new OleDbCommand(sorgu, baglan);

                
                komut.Parameters.AddWithValue("@ad", KULLANICI_ADI);
                komut.Parameters.AddWithValue("@soyad", KULLANICI_SOYADI);
                komut.Parameters.AddWithValue("@tc", TC_KİMLİK_NO);
                komut.Parameters.AddWithValue("@telefon", KULLANICI_TELEFON_NUMARASI);
                komut.Parameters.AddWithValue("@adres", KULLANICI_ADRESİ);
                komut.Parameters.AddWithValue("@kurum", BAĞLI_OLDUĞU_KURUM);

                komut.ExecuteNonQuery();
                baglan.Close();
            }

            
            public void güncelle_müşteri_bilgileri(string filitre, string KULLANICI_ADI, string KULLANICI_SOYADI, string KULLANICI_TELEFON_NUMARASI, string KULLANICI_ADRESİ, string BAĞLI_OLDUĞU_KURUM, string KAYIT_TARİHİ, string TC_KİMLİK_NO)
            {
                OleDbCommand komut = null;
                string sorgu = "UPDATE MUSTERİ_BİLGİLERİ SET kullanıcı_adı = @ad,kullanıcı_soyadı= @soyad,kullanıcı_telefon_no=@telefon,adres =@adres,bağlı_olduğu_kurum= @kurum,kayıt_tarihi= @tarih,tc= @tc WHERE " + filitre;
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("@ad", KULLANICI_ADI);
                komut.Parameters.Add("@soyad", KULLANICI_SOYADI);
                komut.Parameters.Add("@telefon", KULLANICI_TELEFON_NUMARASI);
                komut.Parameters.Add("@adres", KULLANICI_ADRESİ);
                komut.Parameters.Add("@kurum", BAĞLI_OLDUĞU_KURUM);
                komut.Parameters.Add("@tarih", KAYIT_TARİHİ);
                komut.Parameters.Add("@tc", TC_KİMLİK_NO);

                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void ekle_satılan_ilaç(string BARKOD_KODU, string ÜRETİCİ_FİRMA, string SATILAN_İLACIN_ADI, string MÜŞTERİ_ID, string SATIŞ_TARİHİ, string ADETİ, string ÜRÜN_FİYATI)
            {
                OleDbCommand komut = null;
                string sorgu = "INSERT INTO SATILAN_İLAÇ (barkod_kodu, üretici_firma, satılan_ilacın_adı, müşteri_id, satış_tarihi, adeti, ürün_fiyatı) VALUES (@barkod,@firma,@ilaç,@müşteri,@tarih,@adet,@fiyat)";
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("@barkod", BARKOD_KODU);
                komut.Parameters.Add("@firma", ÜRETİCİ_FİRMA);
                komut.Parameters.Add("@ilaç", SATILAN_İLACIN_ADI);
                komut.Parameters.Add("@müşteri", MÜŞTERİ_ID);
                komut.Parameters.Add("@tarih", SATIŞ_TARİHİ);
                komut.Parameters.Add("@adet", ADETİ);
                komut.Parameters.Add("@fiyat", ÜRÜN_FİYATI);
                komut.ExecuteNonQuery();
                baglan.Close();

            }
            public void güncelle_satılan_ilaç(string filitre, string BARKOD_KODU, string ÜRETİCİ_FİRMA, string SATILAN_İLACIN_ADI, string MÜŞTERİ_ID, string SATIŞ_TARİHİ, string ADETİ, string ÜRÜN_FİYATI)
            {
                string sorgu = "UPDATE SATILAN_İLAÇ SET barkod_kodu =@barkod, üretici_firma= @firma, satılan_ilacın_adı= @ilaç, müşteri_id= @müşteri, satış_tarihi=@tarih, adeti= @adet, ürün_fiyatı= @fiyat   WHERE " + filitre;
                OleDbCommand komut = null;
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("@barkod", BARKOD_KODU);
                komut.Parameters.Add("@firma", ÜRETİCİ_FİRMA);
                komut.Parameters.Add("@ilaç", SATILAN_İLACIN_ADI);
                komut.Parameters.Add("@müşteri", MÜŞTERİ_ID);
                komut.Parameters.Add("@tarih", SATIŞ_TARİHİ);
                komut.Parameters.Add("@adet", ADETİ);
                komut.Parameters.Add("@fiyat", ÜRÜN_FİYATI);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void ekle_stok(string BARKOD_KODU, string ÜRETİCİ_FİRMA, string İLAÇ_ADI, string STOK_ADEDİ, string STOK_GİRİŞ_TARİHİ, string SON_KULLANMA_TARİHİ, string ÜRÜN_ALIM_FİYATI, string ÜRÜNÜN_SATIŞ_FİYATI, string İLACIN_ETKİLERİ, string İLACIN_YAN_ETKİLERİ)
            {
                OleDbCommand komut = null;
                baglan.Open();
                string sorgu = "INSERT INTO STOK (barkod_kodu , üretici_firma, ilaç_adı, stok_adedi, stok_giriş_tarihi, SKT , ürün_alım_fiyatı, ürün_satıs_fiyatı, ilacın_etkileri,ilacın_yanetkileri ) VALUES (@barkod , @firma , @ilaç , @stok ,@giriş_tarihi,@skt,@alım_fiyatı,@satış_fiyatı,@etkileri,@yan_etkileri)";

                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("@barkod", BARKOD_KODU);
                komut.Parameters.Add("@firma", ÜRETİCİ_FİRMA);
                komut.Parameters.Add("@ilaç", İLAÇ_ADI);
                komut.Parameters.Add("@stok", STOK_ADEDİ);
                komut.Parameters.Add("@giriş_tarihi", STOK_GİRİŞ_TARİHİ);
                komut.Parameters.Add("@skt", SON_KULLANMA_TARİHİ);
                komut.Parameters.Add("@alım_fiyatı", ÜRÜN_ALIM_FİYATI);
                komut.Parameters.Add("@satış_fiyatı,", ÜRÜNÜN_SATIŞ_FİYATI);
                komut.Parameters.Add("@etkileri", İLACIN_ETKİLERİ);
                komut.Parameters.Add("@yan_etkileri", İLACIN_YAN_ETKİLERİ);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void güncelle_stok(string filitre, string BARKOD_KODU, string ÜRETİCİ_FİRMA, string İLAÇ_ADI, string STOK_ADEDİ, string STOK_GİRİŞ_TARİHİ, string SON_KULLANMA_TARİHİ, string ÜRÜN_ALIM_FİYATI, string ÜRÜNÜN_SATIŞ_FİYATI, string İLACIN_ETKİLERİ, string İLACIN_YAN_ETKİLERİ)
            {
                OleDbCommand komut = null;
                string sorgu = "UPDATE STOK SET barkod_kodu =@barkod , üretici_firma =@firma , ilaç_adı = @ilaç , stok_adedi =@stok , stok_giriş_tarihi=@giriş_tarihi, SKT=@skt, ürün_alım_fiyatı =@alım_fiyatı, ürün_satıs_fiyatı=@satış_fiyatı, ilacın_etkileri=@etkileri,ilacın_yan_etkileri =@yan_etkileri WHERE " + filitre;
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("@barkod", BARKOD_KODU);
                komut.Parameters.Add("@firma", ÜRETİCİ_FİRMA);
                komut.Parameters.Add("@ilaç", İLAÇ_ADI);
                komut.Parameters.Add("@stok", STOK_ADEDİ);
                komut.Parameters.Add("@giriş_tarihi", STOK_GİRİŞ_TARİHİ);
                komut.Parameters.Add("@skt", SON_KULLANMA_TARİHİ);
                komut.Parameters.Add("@alım_fiyatı", ÜRÜN_ALIM_FİYATI);
                komut.Parameters.Add("@satış_fiyatı,", ÜRÜNÜN_SATIŞ_FİYATI);
                komut.Parameters.Add("@etkileri", İLACIN_ETKİLERİ);
                komut.Parameters.Add("@yan_etkileri", İLACIN_YAN_ETKİLERİ);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void ekle_yönetici(string ÇALIŞAN_ADI, string ÇALIŞAN_SOYADI, string ÇALIŞAN_ŞİFRESİ, string KONUMU, string ÇALIŞAN_BİLGİLERİ, string MAAŞ)
            {
                OleDbCommand komut = null;
                string sorgu = "INSERT INTO YONETİCİ (çalışan_adı,çalışan_soyadı,çalışan_şifresi,konumu,çalışan_bilgileri,maaş) VALUES (@ad,@soyad,@şifre,@konum,@bilgi,@maaş)";
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("", ÇALIŞAN_ADI);
                komut.Parameters.Add("", ÇALIŞAN_SOYADI);
                komut.Parameters.Add("", ÇALIŞAN_ŞİFRESİ);
                komut.Parameters.Add("", KONUMU);
                komut.Parameters.Add("", ÇALIŞAN_BİLGİLERİ);
                komut.Parameters.Add("", MAAŞ);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void güncelle_yönetici(string filitre, string ÇALIŞAN_ADI, string ÇALIŞAN_SOYADI, string ÇALIŞAN_ŞİFRESİ, string KONUMU, string ÇALIŞAN_BİLGİLERİ, string MAAŞ)
            {
                baglan.Open();
                OleDbCommand komut = null;
                string sorgu = "UPDATE YONETİCİ SET çalışan_adıI=@ad,çalışan_soyadı=@soyad,çalışan_şifresi=@şifre,konumu=@konum,çalışan_bilgileri=@bilgi,maaş =@maaş WHERE " + filitre;

                komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.Add("", ÇALIŞAN_ADI);
                komut.Parameters.Add("", ÇALIŞAN_SOYADI);
                komut.Parameters.Add("", ÇALIŞAN_ŞİFRESİ);
                komut.Parameters.Add("", KONUMU);
                komut.Parameters.Add("", ÇALIŞAN_BİLGİLERİ);
                komut.Parameters.Add("", MAAŞ);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            public void sil(string tabloadi, string filitre)
            {
                OleDbCommand komut = null;
                string sorgu = "DELETE FROM " + tabloadi + " WHERE " + filitre;
                baglan.Open();
                komut = new OleDbCommand(sorgu, baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
        }
    }

}
