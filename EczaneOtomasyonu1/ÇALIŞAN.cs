using EczaneOtomasyonu1.Eczane_Otomasyonu_Yeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyonu1
{
    public partial class ÇALIŞAN : Form
    {
        Veri_Tabanı_Sorgulama vtb = new Veri_Tabanı_Sorgulama();
        public ÇALIŞAN()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int adet = Convert.ToInt32(txtAdet.Text);
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            int tutar = fiyat * adet;

            txtTutar.Text = tutar.ToString(); 

            
            dataGridView1.Rows.Add(txtStokAdedi.Text, adet, fiyat, tutar);
        }

        

        private void butonilaçsatıç_hastakontrol_Click_Click(object sender, EventArgs e)
        {
            {

                string tcNo = txtTcKimlik.Text;

                if (string.IsNullOrEmpty(tcNo))
                {
                    MessageBox.Show("Lütfen arama yapmak için bir TC Kimlik No giriniz.");
                    return;
                }

                
                OleDbDataReader oku = vtb.sorgula("SELECT * FROM MUSTERİ_BİLGİLERİ WHERE tc_kimlik_no LIKE '" + tcNo + "'", false);

                if (oku.Read())
                {

                    txtMusteriAd.Text = oku["kullanıcı_adı"].ToString();
                    txtMusteriSoyad.Text = oku["kullanıcı_soyadı"].ToString();
                    txtTelefon.Text = oku["kullanıcı_telefon_no"].ToString();
                    txtKayitTarihi.Text = oku["kayıt_tarihi"].ToString();
                    cmbKurum.Text = oku["bağlı_olduğu_kurum"].ToString();
                }
                else
                {
                    if (MessageBox.Show("HASTAYI SİSTEME KAYDETMEK İSTERMİSİNİZ ?", "HASTA KAYITLI DEĞİL !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        vtb.baglan.Close();
                        
                        return;
                    }
                }
                vtb.baglan.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OleDbDataReader oku = vtb.sorgula("SELECT * FROM STOK WHERE ilaç_adı LIKE '" + cmbIlacAdi.Text + "' OR barkod_kodu LIKE '" + cmbIlacAdi.Text + "'", false);

            if (oku.Read())
            {
                
                txtStokAdedi.Text = oku["stok_adedi"].ToString();
                txtFiyat.Text = oku["ürünün_satış_fiyatı"].ToString();
            }
            else
            {
                if (MessageBox.Show("İLACI SİSTEME KAYDETMEK İSTERMİSİNİZ ?", "İLAÇ KAYITLI DEĞİL !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vtb.baglan.Close();
                    
                    return;
                }
            }
            vtb.baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Satış listesinde ürün bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbDataReader oku = null;
            string musteriId = "";

            oku = vtb.sorgula("SELECT * FROM MUSTERİ_BİLGİLERİ WHERE kullanıcı_adı LIKE '" + txtMusteriAd.Text + "' AND kullanıcı_soyadı LIKE '" + txtMusteriSoyad.Text + "'", false);
            if (oku.Read())
            {
                musteriId = oku["ID"].ToString();
            }
            vtb.baglan.Close();

           
            DateTime tarih = DateTime.Now;
            string satisTarihi = tarih.Year + "" + tarih.Month.ToString("00") + "" + tarih.Day.ToString("00");

           
            foreach (DataGridViewRow satır in dataGridView1.Rows)
            {
                
                if (satır.IsNewRow) continue;

                
                string ilacadi = satır.Cells[0].Value.ToString();  
                string adet = satır.Cells[1].Value.ToString();    
                string fiyat = satır.Cells[2].Value.ToString();    

                string barkod = "";
                string ureticifirma = "";

                
                oku = vtb.sorgula("SELECT * FROM STOK WHERE ilaç_adı LIKE '" + ilacadi + "'", false);
                if (oku.Read())
                {
                    barkod = oku["barkod_kodu"].ToString();
                    ureticifirma = oku["üretici_firma"].ToString();
                }
                vtb.baglan.Close();

                
                vtb.ekle_satılan_ilaç(barkod, ureticifirma, ilacadi, musteriId, satisTarihi, adet, fiyat);
            }

            dataGridView1.Rows.Clear();

            txtTcKimlik.Clear(); 
            txtMusteriAd.Clear(); 
            txtMusteriSoyad.Clear(); 
            txtTelefon.Clear(); 
            txtKayitTarihi.Clear(); 
            txtAdet.Text = "0"; 
            txtFiyat.Text = "0"; 
            txtTutar.Text = "0"; 
            textstok_adı.SelectedIndex = -1; 

            MessageBox.Show("Satış işlemi başarıyla tamamlandı ve veri tabanına işlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           
            private void btnSatisiOnayla_Click(object sender, EventArgs e)
            {
            
            if (string.IsNullOrEmpty(txtMusteriAd.Text) || string.IsNullOrEmpty(cmbIlacAdi.Text) || string.IsNullOrEmpty(txtAdet.Text))
            {
                MessageBox.Show("Lütfen müşteri ve ilaç bilgilerini eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbDataReader oku = null;
            string barkod = "", ureticifirma = "", musteriId = "";
            string ilacadi = cmbIlacAdi.Text;
            string adet = txtAdet.Text;
            string fiyat = txtFiyat.Text;

            
            oku = vtb.sorgula("SELECT * FROM STOK WHERE ilaç_adı LIKE '" + ilacadi + "'", false);
            if (oku.Read())
            {
                barkod = oku["barkod_kodu"].ToString();
                ureticifirma = oku["üretici_firma"].ToString();
            }
            vtb.baglan.Close();

            oku = vtb.sorgula("SELECT * FROM MUSTERİ_BİLGİLERİ WHERE kullanıcı_adı LIKE '" + txtMusteriAd.Text + "' AND kullanıcı_soyadı LIKE '" + txtMusteriSoyad.Text + "'", false);
            if (oku.Read())
            {
                musteriId = oku["ID"].ToString();
            }
            vtb.baglan.Close();

            
            DateTime tarih = DateTime.Now;
            string satisTarihi = tarih.Year + "" + tarih.Month.ToString("00") + "" + tarih.Day.ToString("00");

            
            vtb.ekle_satılan_ilaç(barkod, ureticifirma, ilacadi, musteriId, satisTarihi, adet, fiyat);

            
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtTcKimlik.Clear();
            txtTelefon.Clear();
            txtTutar.Text = "0";
            txtFiyat.Text = "0";
            txtAdet.Text = "0";
            cmbIlacAdi.SelectedIndex = -1; 

            MessageBox.Show("Satış başarıyla veri tabanına kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTcKimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
