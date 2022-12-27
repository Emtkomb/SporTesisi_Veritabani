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
    public partial class Musteri : Form
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
        public Musteri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmusterino.Text) & !string.IsNullOrWhiteSpace(txtmusteriadi.Text) & !string.IsNullOrWhiteSpace(txtmusterisyadi.Text) & !string.IsNullOrWhiteSpace(txtmusteritfn.Text) & !string.IsNullOrWhiteSpace(txtmusteriemail.Text) & !string.IsNullOrWhiteSpace(txtkiratrh.Text))
            {
                baglanti.Open();

                NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"sportesisi\".\"musteri\"(\"musteriNo\",\"musteriAdi\",\"musteriSoyadi\",\"Telefon\",\"Email\",\"kiraTarihi\") VALUES (@p1, @p2, @p3, @p4,@p5,@p6)", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(txtmusterino.Text));
                komut1.Parameters.AddWithValue("@p2", txtmusteriadi.Text);
                komut1.Parameters.AddWithValue("@p3", txtmusterisyadi.Text);
                komut1.Parameters.AddWithValue("@p4", txtmusteritfn.Text);
                komut1.Parameters.AddWithValue("@p5", txtmusteriemail.Text);
                komut1.Parameters.AddWithValue("@p6", txtkiratrh.Text);

                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Müşteri Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Müşteri Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnmusterigrntl_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"musteri\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datamusteri.DataSource = ds.Tables[0];
        }

        private void btnmusterisil_Click(object sender, EventArgs e)
        {
            DialogResult onaysil = MessageBox.Show("Kayıt Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onaysil == DialogResult.Yes)
            {
                baglanti.Open();
                string sil = "DELETE  from \"sportesisi\".\"musteri\" where \"musteriNo\"='" + txtmusterino.Text + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand(sil, baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtmusterino.Text));
                if (komut2.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
                else { MessageBox.Show("Silme İşlemi Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }
        }

        private void btnmusterignclle_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Kayıt Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"musteri\" set  \"musteriAdi\"=@p1,\"musteriSoyadi\"=@p2,\"Telefon\"=@p3,\"Email\"=@p4,\"kiraTarihi\"=@p5 where \"musteriNo\"=@p6";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                komut5.Parameters.AddWithValue("@p1", txtmusteriadi.Text);
                komut5.Parameters.AddWithValue("@p2", txtmusterisyadi.Text);
                komut5.Parameters.AddWithValue("@p3", txtmusteritfn.Text);
                komut5.Parameters.AddWithValue("@p4", txtmusteriemail.Text);
                komut5.Parameters.AddWithValue("@p5", txtkiratrh.Text);
                komut5.Parameters.AddWithValue("@p6", int.Parse(txtmusterino.Text));

                if (komut5.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Personel Kaydı Güncellendi ..!");
                }
                else { MessageBox.Show("Günceleme Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }
        }

        private void btnmusteriara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtmusterino.Text))
            {
                baglanti.Open();
                string ara = "SELECT * from \"sportesisi\".\"musteri\" where \"musteriNo\"=@no";
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                komut4.Parameters.AddWithValue("@no", int.Parse(txtmusterino.Text));
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                NpgsqlDataReader oku = komut4.ExecuteReader();
                if (oku.Read())
                {
                    datamusteri.DataSource = dst1.Tables[0];
                }
                else { MessageBox.Show("Kayıt Bulunamadı Tekrar Deneyiniz...!"); }
                baglanti.Close();
                txtboxTemizle();
            }
            else { MessageBox.Show("Lütfen Müşteri No Giriniz..!"); }
        }
    }
}
