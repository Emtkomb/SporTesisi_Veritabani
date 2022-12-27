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
    
    public partial class personelimiz : Form
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
        public personelimiz()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");
        private void btnprsnllste_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"Personel\" INNER JOIN \"sportesisi\".\"calisan\"ON \"sportesisi\".\"Personel\".\"personelid\" = \"sportesisi\".\"calisan\".\"personelid\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagrdipsnl.DataSource = ds.Tables[0];
        }

        private void btnprsnlara_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtprsnlid.Text))
            {
                baglanti.Open();
                string ara = "SELECT * from \"sportesisi\".\"Personel\" where \"personelid\"=@no";
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                komut4.Parameters.AddWithValue("@no", int.Parse(txtprsnlid.Text));
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                NpgsqlDataReader oku = komut4.ExecuteReader();
                if (oku.Read())
                {
                    datagrdipsnl.DataSource = dst1.Tables[0];
                }
                else { MessageBox.Show("Kayıt Bulunamadı Tekrar Deneyiniz...!"); }
                baglanti.Close();
                txtboxTemizle();
            }
            else { MessageBox.Show("Lütfen Personel ID Giriniz..!"); }
        }

  

        private void btnprsnlsil_Click(object sender, EventArgs e)
        {
            DialogResult onaysil = MessageBox.Show("Kayıt Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onaysil == DialogResult.Yes)
            {
                baglanti.Open();
                string sil = "DELETE  from \"sportesisi\".\"Personel\" where \"personelid\"='" + txtprsnlid.Text + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand(sil, baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtprsnlid.Text));
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

        private void btnprsnlgncelle_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Kayıt Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"Personel\" set  \"adi\"=@p1,\"soyadi\"=@p2,\"maas\"=@p3 ,\"maas\"=@p3where \"personelid\"=@p4";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                komut5.Parameters.AddWithValue("@p1", txtpersnladi.Text);
                komut5.Parameters.AddWithValue("@p2", txtpersnlsoyadi.Text);
                komut5.Parameters.AddWithValue("@p3", txtpersnlmaas.Text);
                komut5.Parameters.AddWithValue("@p4", int.Parse(txtprsnlid.Text));

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

        private void btngrvlilist_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"Personel\" INNER JOIN \"sportesisi\".\"tesisgorevlisi\"ON \"sportesisi\".\"Personel\".\"personelid\" = \"sportesisi\".\"tesisgorevlisi\".\"personelid\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagrdipsnl.DataSource = ds.Tables[0];
        }

        private void btnclsnekle_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtcalisanid.Text) & !string.IsNullOrWhiteSpace(txtcalisanno.Text))
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"sportesisi\".\"calisan\"(\"personelid\",\"calisanno\") values(@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(txtcalisanid.Text));
                komut1.Parameters.AddWithValue("@p2", int.Parse(txtcalisanno.Text));


                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Çalışan Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Çalışan Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnprsnlgrntl_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM \"sportesisi\".\"Personel\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagrdipsnl.DataSource = ds.Tables[0];
           
        }

        private void btnprsnlekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtprsnlid.Text) & !string.IsNullOrWhiteSpace(txtpersnladi.Text) & !string.IsNullOrWhiteSpace(txtpersnlsoyadi.Text) & !string.IsNullOrWhiteSpace(txtpersnlmaas.Text))
            {
                baglanti.Open();

                NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"sportesisi\".\"Personel\"(\"personelid\",\"adi\",\"soyadi\",\"maas\") VALUES (@p1, @p2, @p3, @p4)", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(txtprsnlid.Text));
                komut1.Parameters.AddWithValue("@p2", txtpersnladi.Text);
                komut1.Parameters.AddWithValue("@p3", txtpersnlsoyadi.Text);
                komut1.Parameters.AddWithValue("@p4", txtpersnlmaas.Text);

               

                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Personel Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Personel Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();

         

        }

        private void btngrvlekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtgorevliid.Text) & !string.IsNullOrWhiteSpace(txtgorevlino.Text))
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"sportesisi\".\"tesisgorevlisi\"(\"personelid\",\"gorevlino\") values(@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(txtgorevliid.Text));
                komut1.Parameters.AddWithValue("@p2", int.Parse(txtgorevlino.Text));


                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Görevli Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Görevli Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnegitmenekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtegitmenid.Text) & !string.IsNullOrWhiteSpace(txtegitmenno.Text))
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"sportesisi\".\"egitmen\"(\"personelid\",\"egitmenNo\") values(@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(txtegitmenid.Text));
                komut1.Parameters.AddWithValue("@p2", int.Parse(txtegitmenno.Text));


                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Eğitmen Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Eğitmen Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnegitmenlistele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"Personel\" INNER JOIN \"sportesisi\".\"egitmen\"ON \"sportesisi\".\"Personel\".\"personelid\" = \"sportesisi\".\"egitmen\".\"personelid\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagrdipsnl.DataSource = ds.Tables[0];
        }
    }
}
