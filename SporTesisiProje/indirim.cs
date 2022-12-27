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
    public partial class indirim : Form
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
        public indirim()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");

        private void btngrntle_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM \"sportesisi\".\"indirim\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridindirm.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtikod.Text) & !string.IsNullOrWhiteSpace(txtioran.Text))
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"sportesisi\".\"indirim\"(\"indirimKodu\",\"indirimorani\") values(@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", txtikod.Text);
                komut1.Parameters.AddWithValue("@p2", int.Parse(txtioran.Text));


                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("İndirim Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("İndirim Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnindirimara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtikod.Text))
            {
                baglanti.Open();
                string ara = "SELECT * from \"sportesisi\".\"indirim\" where \"indirimKodu\"=@no";
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                komut4.Parameters.AddWithValue("@no", txtikod.Text);
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                NpgsqlDataReader oku = komut4.ExecuteReader();
                if (oku.Read())
                {
                    datagridindirm.DataSource = dst1.Tables[0];
                }
                else { MessageBox.Show("Kayıt Bulunamadı Tekrar Deneyiniz...!"); }
                baglanti.Close();
                txtboxTemizle();
            }
            else { MessageBox.Show("Lütfen İndirim Kodu Giriniz..!"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult onaysil = MessageBox.Show("Kayıt Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onaysil == DialogResult.Yes)
            {
                baglanti.Open();
                string sil = "DELETE  from \"sportesisi\".\"indirim\" where \"indirimKodu\"='" + txtikod.Text + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand(sil, baglanti);
                komut2.Parameters.AddWithValue("@p1", txtikod.Text);
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

        private void btngncl_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Kayıt Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"indirim\" set  \"indirimorani\"=@p1 where \"indirimKodu\"=@p2";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                komut5.Parameters.AddWithValue("@p2", txtikod.Text);       
                komut5.Parameters.AddWithValue("@p1", int.Parse(txtioran.Text));

                if (komut5.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("İndirim Kaydı Güncellendi ..!");
                }
                else { MessageBox.Show("Günceleme Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }

           
        }
    }
}
