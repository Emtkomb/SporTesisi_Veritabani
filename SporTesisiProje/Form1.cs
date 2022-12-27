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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=sqlsportesisi;user ID=postgres;Password=emtkomb;");

        private void btnsahalar_Click(object sender, EventArgs e)
        {
            Sahalarımız yeniSayfa = new Sahalarımız();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

       

       
        private void btnkirala_Click(object sender, EventArgs e)
        {
            Saha yeniSayfa = new Saha();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();

        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            personelimiz yeniSayfa = new personelimiz();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            iletisim yeniSayfa = new iletisim();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void btnsahalar_Click_1(object sender, EventArgs e)
        {
            Musteri yeniSayfa = new Musteri();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void btnduyurugrntl_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"sportesisi\".\"duyurular\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridduyuru.DataSource = ds.Tables[0];
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            Duyuru yeniSayfa = new Duyuru();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }
    }
}
