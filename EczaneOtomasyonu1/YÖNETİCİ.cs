using EczaneOtomasyonu1.Eczane_Otomasyonu_Yeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu1
{
    public partial class YÖNETİCİ : Form
    {
        Veri_Tabanı_Sorgulama vtb = new Veri_Tabanı_Sorgulama();
        public YÖNETİCİ()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_Click(object sender, EventArgs e)
        {
            try
            {
                
                vtb.ekle_yönetici(
                    texçalışan_ad.Text,
                    texçalışan_soyad.Text,
                    texçalışan_şifre.Text,
                    texçalışan_konum.Text,
                    texçalışan_bilgi.Text,
                    texçalışan_maaş.Text
                );

                MessageBox.Show("Yeni çalışan başarıyla eklendi!");

                
                texçalışan_ad.Clear();
                texçalışan_soyad.Clear();
                texçalışan_şifre.Clear();
                texçalışan_bilgi.Clear();
                texçalışan_maaş.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu: " + ex.Message);
            }
        } 
            private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                vtb.ekle_yönetici(
                    texçalışan_ad.Text,
                    texçalışan_soyad.Text,
                    texçalışan_şifre.Text,
                    texçalışan_konum.Text,
                    texçalışan_bilgi.Text,
                    texçalışan_maaş.Text
                );
                MessageBox.Show("Çalışan başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button7_Click_Click(object sender, EventArgs e)
        {
           
        }
            private void btnStokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                vtb.ekle_satılan_ilaç(
                    textstok_barkod.Text,
                    textstok_firma.Text,
                    textstok_adı.Text,
                    textstok_adeti.Text,
                    textstok_alışfiyatı.Text,
                    textstok_satışfiyatı.Text,
                    textstok_etkileri.Text     
                );
                MessageBox.Show("İlaç stoğa eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                vtb.ekle_müşteri_bilgileri(
                    textmüşteri_ad.Text,
                    textmüşteri_soyad.Text,
                    textmüşteri_telefon.Text,
                    comboBoxmüşteri_kurum.Text,
                    textmüşteri_tarih.Text,
                    textmüşteri_tc.Text,
                    textmüşteri_adres.Text
                    
                );

                MessageBox.Show("Müşteri kaydı başarıyla oluşturuldu!");

                
                textmüşteri_soyad.Clear();
                textmüşteri_tc.Clear();
                textmüşteri_telefon.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenirken hata oluştu: " + ex.Message);
            }
        }
            private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void button19_Click_Click(object sender, EventArgs e)
        {
            try
            {
                
                vtb.sil("STOK", "ilaç_adı='" + textstok_adı.Text + "'");

                MessageBox.Show("İlaç stoktan başarıyla silindi.");

                
                textstok_adı.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız: " + ex.Message);
            }
        }

        private void button8_click_Click(object sender, EventArgs e)
        {
            try
            {
                
                vtb.sil("YONETİCİ", "çalışan_adı='" + texçalışan_ad.Text + "'");

                MessageBox.Show("Çalışan sistemden silindi.");

                texçalışan_ad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız: " + ex.Message);
            }
        }

        private void button20_click_Click(object sender, EventArgs e)
        {
            try
            {
                
                string filtre = "çalışan_adı='" + texçalışan_ad.Text + "'";

                
                vtb.güncelle_yönetici(
                    filtre,
                    texçalışan_ad.Text,
                    texçalışan_soyad.Text,
                    texçalışan_şifre.Text,
                    texçalışan_konum.Text,
                    texçalışan_bilgi.Text,
                    texçalışan_maaş.Text
                );

                MessageBox.Show("Çalışan bilgileri başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void button5_Click_Click(object sender, EventArgs e)
        {
            try
            {
                
                vtb.sil("STOK", "ilaç_adı='" + textstok_adı.Text + "'");

                MessageBox.Show("İlaç stoktan başarıyla silindi.");

                
                textstok_adı.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                
                vtb.sil("MUSTERİ_BİLGİLERİ", "tc='" + textmüşteri_tc.Text + "'");

                MessageBox.Show("Müşteri kaydı başarıyla silindi.");

                
                textmüşteri_tc.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                
                string filtre = "tc='" + textmüşteri_tc.Text + "'";

                
                vtb.güncelle_müşteri_bilgileri(
                    filtre,
                    textmüşteri_ad.Text,
                    textmüşteri_soyad.Text,
                    textmüşteri_tc.Text,
                    textmüşteri_telefon.Text,
                    comboBoxmüşteri_kurum.Text,
                    textmüşteri_tarih.Text,
                    textmüşteri_adres.Text
                );

                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }
    }
    }
    
    
    

