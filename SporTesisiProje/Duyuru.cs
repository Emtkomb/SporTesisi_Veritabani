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
    public partial class Duyuru : Form
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
        public Duyuru()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand cmd = baglanti.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into \"sportesisi\".\"duyurular\" values('" + txtduyuruno.Text + "','" + txtrichduyuru.Text + "','" + txtindirimkd.Text + "')";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru eklendi");
        }

        private void btnduyurusil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand cmd = baglanti.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete  from  \"sportesisi\".\"duyurular\" where\"duyuruNo\"='" + txtduyuruno.Text + "'";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DialogResult onayguncelle = MessageBox.Show("Duyuruyu Guncellemek İstediğinizden Emin Misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onayguncelle == DialogResult.Yes)
            {
                baglanti.Open();
                string kayit2 = "update \"sportesisi\".\"duyurular\" set  \"duyuru\"=@p1 where \"duyuruNo\"=@p4";
                NpgsqlCommand komut5 = new NpgsqlCommand(kayit2, baglanti);


                komut5.Parameters.AddWithValue("@p1", txtrichduyuru.Text);
                komut5.Parameters.AddWithValue("@p4", int.Parse(txtduyuruno.Text));

                if (komut5.ExecuteNonQuery() > 0)
                {
                    baglanti.Close();
                    txtboxTemizle();
                    MessageBox.Show("Duyuru Güncellendi ..!");
                }
                else { MessageBox.Show("Günceleme Başarısız"); }
                baglanti.Close();
            }
            else { MessageBox.Show("İşlem İptal Edildi"); }
        }
    }
}
