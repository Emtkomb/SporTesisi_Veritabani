using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Npgsql;


namespace SporTesisiProje
{
    public partial class Sahalarımız : Form
    {
        public void txtboxTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();

                }
            }
        }
        public Sahalarımız()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtsahaNo.Text) & !string.IsNullOrWhiteSpace(txtsahaadi.Text) & !string.IsNullOrWhiteSpace(txtucret.Text))
            {
                baglanti.Open();

                NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"sportesisi\".\"Sahalarimiz\"(\"sahaNo\",\"sahaAdi\",\"ucret\") VALUES (@p1, @p2,@p3)", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(txtsahaNo.Text));
                komut1.Parameters.AddWithValue("@p2", txtsahaadi.Text);
                komut1.Parameters.AddWithValue("@p3", int.Parse(txtucret.Text));


                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Saha Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Saha Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btngrntle_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"Sahalarimiz\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridsaha.DataSource = ds.Tables[0];
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            DialogResult onaysil = MessageBox.Show("Kayıt Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onaysil == DialogResult.Yes)
            {
                baglanti.Open();
                string sil = "DELETE  from \"sportesisi\".\"Sahalarimiz\" where \"sahaNo\"='" + txtsahaNo.Text + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand(sil, baglanti);
                komut2.Parameters.AddWithValue("@p1", txtsahaadi.Text);
                if (komut2.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Başarısız");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Kayıt Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"Sahalarimiz\" set  \"ucret\"=@p1  where \"sahaNo\"=@p2";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                
               
                komut5.Parameters.AddWithValue("@p1", int.Parse(txtucret.Text));


                komut5.Parameters.AddWithValue("@p2", int.Parse(txtsahaNo.Text));

                if (komut5.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Saha Güncellendi ..!");
                }
                else { MessageBox.Show("Günceleme Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }
        }

       

        private void btnsahara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtsahaNo.Text))
            {
                baglanti.Open();
                string ara = "SELECT * from \"sportesisi\".\"Sahalarimiz\" where \"sahaNo\"=@no";
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                komut4.Parameters.AddWithValue("@no", int.Parse(txtsahaNo.Text));
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                NpgsqlDataReader oku = komut4.ExecuteReader();
                if (oku.Read())
                {
                    datagridsaha.DataSource = dst1.Tables[0];
                }
                else { MessageBox.Show("Kayıt Bulunamadı Tekrar Deneyiniz...!"); }
                baglanti.Close();
                txtboxTemizle();
            }
            else { MessageBox.Show("Lütfen Personel ID Giriniz..!"); }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "admin";
            string sifre = "12345";

            if(kullaniciadi == txtkullaniciadi.Text && sifre == txtsifre.Text)
            {
                lblkullaniciadi.Visible = false;
                lblsifre.Visible = false;
                txtkullaniciadi.Visible = false;
                txtsifre.Visible = false;
                btngiris.Visible = false;
                datagridsaha.Visible = true;
                btngrntle.Visible = true;
                btnsahara.Visible  = true;
                label1.Visible = true;
                label2.Visible = true;
                txtsahaNo.Visible = true;
                txtucret.Visible = true;
                btngncl.Visible = true;

            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }


        }
    }
}
