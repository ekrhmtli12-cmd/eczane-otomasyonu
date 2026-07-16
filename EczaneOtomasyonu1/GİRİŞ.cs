using EczaneOtomasyonu1.Eczane_Otomasyonu_Yeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyonu1
{
    public partial class GİRİŞ : Form
    {
        Veri_Tabanı_Sorgulama vtb = new Veri_Tabanı_Sorgulama();
        public GİRİŞ()
        {
            InitializeComponent();
        }

       
            private void Form1_Load(object sender, EventArgs e)
        {
            
            
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (vtb.baglan.State == System.Data.ConnectionState.Open)
                {
                    vtb.baglan.Close();
                }

                
                string user = textkullanıcı_adı.Text.Trim();
                string pass = textkullanıcı_şifre.Text.Trim();

                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını boş bırakmayınız!", "Uyarı");
                    return;
                }

                
                string sorgu = "SELECT * FROM YONETİCİ WHERE çalışan_adı='" + user + "' AND çalışan_şifresi='" + pass + "'";
                OleDbDataReader oku = vtb.sorgula(sorgu, false);

                if (oku.Read())
                {
                    
                    string yetki = oku["konumu"].ToString().Trim().ToLower();

                    oku.Close();
                    vtb.baglan.Close();

                    
                    if (yetki == "yönetici")
                    {
                        MessageBox.Show("Yönetici Girişi Başarılı!", "Bilgi");

                        YÖNETİCİ yoneticiPaneli = new YÖNETİCİ();

                        yoneticiPaneli.Show();

                        this.Hide();
                    }
                    else if (yetki == "çalışan" || yetki == "calisan")
                    {
                        MessageBox.Show("Çalışan Girişi Başarılı!", "Bilgi");

                        ÇALIŞAN çalışanPaneli = new ÇALIŞAN();

                        çalışanPaneli.Show();
                        
                        this.Hide();
                    }
                    else
                    {
                        
                        MessageBox.Show("Kullanıcı bulundu fakat yetki tanımı (Yönetici/Çalışan) geçersiz! Lütfen veri tabanını kontrol edin.", "Yetki Hatası");
                    }
                }
                else
                {
                    oku.Close();
                    vtb.baglan.Close();
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı! Kullanıcı adı veya şifre hatalı.", "Hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş esnasında bir hata oluştu: " + ex.Message, "Sistem Hatası");
            }
            finally
            {
                if (vtb.baglan.State == System.Data.ConnectionState.Open)
                {
                    vtb.baglan.Close();
                }
            }

        }
            private void btnGirisYap_Click(object sender, EventArgs e)
        {
           
            Veri_Tabanı_Sorgulama vtb = new Veri_Tabanı_Sorgulama();

            
            string kullaniciAd = textkullanıcı_adı.Text.Trim();
            string sifre = textkullanıcı_şifre.Text.Trim();

            
            string sorgu = "SELECT * FROM YONETİCİ WHERE çalışan_adı='" + kullaniciAd + "' AND çalışan_şifresi='" + sifre + "'";

            try
            {
                var oku = vtb.sorgula(sorgu, false);

                if (oku.Read())
                {
                    MessageBox.Show("Giriş Başarılı! Hoşgeldiniz " + oku["çalışan_adı"].ToString()); 
            
            
            GİRİŞ anaForm = new GİRİŞ();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!"); 
        }
                vtb.baglan.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        
            private void btnGiris_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
    

