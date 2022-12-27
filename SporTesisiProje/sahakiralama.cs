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
    public partial class sahakiralama : Form
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
        public sahakiralama()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");
        private void btngrntle_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"SahaKiralama\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridkira.DataSource = ds.Tables[0];
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtno.Text) & !string.IsNullOrWhiteSpace(txtkiraid.Text) & !string.IsNullOrWhiteSpace(txtsahano.Text) & !string.IsNullOrWhiteSpace(txttplmucreet.Text))
            {
                baglanti.Open();

                NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"sportesisi\".\"SahaKiralama\"(\"kiraNo\",\"kiraID\",\"sahaNo\",\"ToplamUcret\") VALUES (@p1,@p2,@p3,@p4)", baglanti);

                komut1.Parameters.AddWithValue("@p1", int.Parse(txtno.Text));
                komut1.Parameters.AddWithValue("@p2", int.Parse(txtkiraid.Text));
                komut1.Parameters.AddWithValue("@p3", int.Parse(txtsahano.Text));                
                               
               komut1.Parameters.AddWithValue("@p4", txttplmucreet.Text);

                if (komut1.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    MessageBox.Show("Kira Kaydı Eklendi ..!");
                    txtboxTemizle();
                }
                else { MessageBox.Show("Kira Kaydı Ekleme Başarısız ..!"); }
            }
            else { MessageBox.Show("Tüm Alanları Doldurunuz ..!"); }
            baglanti.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtno.Text))
            {
                baglanti.Open();
                string ara = "SELECT * from \"sportesisi\".\"SahaKiralama\" where \"kiraNo\"=@no";
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                komut4.Parameters.AddWithValue("@no", int.Parse(txtno.Text));
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                NpgsqlDataReader oku = komut4.ExecuteReader();
                if (oku.Read())
                {
                    datagridkira.DataSource = dst1.Tables[0];
                }
                else { MessageBox.Show("Kayıt Bulunamadı Tekrar Deneyiniz...!"); }
                baglanti.Close();
                txtboxTemizle();
            }
            else { MessageBox.Show("Lütfen Personel ID Giriniz..!"); }
        }

        private void btngnclle_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Kayıt Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"SahaKiralama\" set  \"kiraID\"=@p1,\"sahaNo\"=@p2,\"ToplamUcret\"=@p3 where \"kiraNo\"=@p4";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                komut5.Parameters.AddWithValue("@p1", int.Parse(txtkiraid.Text));
                komut5.Parameters.AddWithValue("@p2", int.Parse(txtsahano.Text));
              
               komut5.Parameters.AddWithValue("@p3", txttplmucreet.Text);
                komut5.Parameters.AddWithValue("@p4", int.Parse(txtno.Text));

                if (komut5.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Saha Kaydı Güncellendi ..!");
                }
                else { MessageBox.Show("Günceleme Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult onaysil = MessageBox.Show("Kayıt Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onaysil == DialogResult.Yes)
            {
                baglanti.Open();
                string sil = "DELETE  from \"sportesisi\".\"SahaKiralama\" where \"kiraNo\"='" + txtno.Text + "'";
                NpgsqlCommand komut2 = new NpgsqlCommand(sil, baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(txtno.Text));
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

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            string ucretbilgi;
            ucretbilgi = ucretcmbbx.Text;
            
            if(ucretbilgi=="Taksitli")
            {
             if(txtsahano.Text == "1")
              { 
                baglanti.Open();
                    string ara = "select \"sportesisi\".\"taksitli\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=1"; 
                NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);            
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                datagridnetucret.DataSource = dst1.Tables[0];
                


                baglanti.Close();
              }
              else  if (txtsahano.Text == "2")
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"taksitli\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=2";
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"taksitli\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=3";
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }

            }
            else if(ucretbilgi=="Pesin")
            {
                if (txtsahano.Text == "1")
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"pesin\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=1"; 
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
                else if (txtsahano.Text == "2")
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"pesin\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=2"; ;
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"pesin\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=3"; ;
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
            }
            else
            {
                if (txtsahano.Text == "1")
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"ogrenci2\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=1";
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
                else if (txtsahano.Text == "2")
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"ogrenci2\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=2";
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    string ara = "select \"sportesisi\".\"ogrenci2\"(ucret) from \"sportesisi\".\"Sahalarimiz\" where  \"sahaNo\"=3";
                    NpgsqlCommand komut4 = new NpgsqlCommand(ara, baglanti);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                    DataSet dst1 = new DataSet();
                    da1.Fill(dst1);
                    datagridnetucret.DataSource = dst1.Tables[0];



                    baglanti.Close();
                }
            }
        }

        private void datagridnetucret_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = datagridnetucret.SelectedCells[0].RowIndex;
            txtdtgrdgr.Text = datagridnetucret.Rows[secilen].Cells[0].Value.ToString();
            if (ucretcmbbx.Text != "Taksitli")
                txttplmucreet.Text = datagridnetucret.Rows[secilen].Cells[0].Value.ToString() + " ₺";
            else
            { 
                txttplmucreet.Text = datagridnetucret.Rows[secilen].Cells[0].Value.ToString();
                txttplmucreet.Text = "3 x" + datagridnetucret.Rows[secilen].Cells[0].Value.ToString() + " = "+  3*int.Parse(txttplmucreet.Text) + " ₺";
            }
        }

        private void btnfutbol_Click(object sender, EventArgs e)
        {
             
             txtsahano.Text = "1";
        }

        private void btnbasketbol_Click(object sender, EventArgs e)
        {
            
            txtsahano.Text = "2";
        }

        private void btntenis_Click(object sender, EventArgs e)
        {
            
            txtsahano.Text = "3";
        }

        private void datagridnetucret_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnuygula_Click(object sender, EventArgs e)
        {
            if(txtindirimkodu.Text == "yaz" || txtindirimkodu.Text == "kış" || txtindirimkodu.Text == "bayram" || txtindirimkodu.Text == "yılbaşı")
            { 
              btnuygula.Visible = false;
              lblbildirim.Visible = true;
            }

        int  ucret;
            ucret = int.Parse(txtdtgrdgr.Text);

            if(txtindirimkodu.Text == "yaz")
            {

                baglanti.Open();
                string uygula = "select \"sportesisi\".\"indirim\"('" + ucret + "', indirimorani) from \"sportesisi\".\"indirim\" where \"indirimKodu\" = 'yaz'";
                NpgsqlCommand komut4 = new NpgsqlCommand(uygula, baglanti);
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                datagridnetucret.DataSource = dst1.Tables[0];



                baglanti.Close();
            }
            else if (txtindirimkodu.Text == "kış")
            {
                baglanti.Open();
                string uygula = "select \"sportesisi\".\"indirim\"('" + ucret + "', indirimorani) from \"sportesisi\".\"indirim\" where \"indirimKodu\" = 'kış'";
                NpgsqlCommand komut4 = new NpgsqlCommand(uygula, baglanti);
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                datagridnetucret.DataSource = dst1.Tables[0];



                baglanti.Close();
            }
            else if (txtindirimkodu.Text == "bayram")
            {
                baglanti.Open();
                string uygula = "select \"sportesisi\".\"indirim\"('" + ucret + "', indirimorani) from \"sportesisi\".\"indirim\" where \"indirimKodu\" = 'bayram'";
                NpgsqlCommand komut4 = new NpgsqlCommand(uygula, baglanti);
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                datagridnetucret.DataSource = dst1.Tables[0];



                baglanti.Close();
            }
            else if (txtindirimkodu.Text == "yılbaşı")
            {
                baglanti.Open();
                string uygula = "select \"sportesisi\".\"indirim\"('" + ucret + "', indirimorani) from \"sportesisi\".\"indirim\" where \"indirimKodu\" = 'yılbaşı'";
                NpgsqlCommand komut4 = new NpgsqlCommand(uygula, baglanti);
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
                DataSet dst1 = new DataSet();
                da1.Fill(dst1);
                datagridnetucret.DataSource = dst1.Tables[0];



                baglanti.Close();
            }










           // baglanti.Open();
           //// string uygula = "select \"sportesisi\".\"indirim\"('" + txtindirimkodu.Text + "', indirimorani) from \"sportesisi\".\"indirim\" where \"indirimKodu\" ="+txtindirimkodu.Text;
           // string uygula = "select \"sportesisi\".\"indirim\"('" + ucret +  "',indirimorani) from \"sportesisi\".\"indirim\"";
           // NpgsqlCommand komut4 = new NpgsqlCommand(uygula, baglanti);
           // NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(komut4);
           // DataSet dst1 = new DataSet();
           // da1.Fill(dst1);
           // datagridnetucret.DataSource = dst1.Tables[0];



           // baglanti.Close();

        }
    }
}
