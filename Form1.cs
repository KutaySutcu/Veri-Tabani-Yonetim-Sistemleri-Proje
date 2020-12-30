using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteArayuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Universite; user ID=postgres; password=1381227");

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"Ogrenci\" (\"ogrenciNo\",\"bolumNo\",\"danisman\",\"ad\",\"soyad\") values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("p1", int.Parse(txtOgrenciNo.Text));
            komut1.Parameters.AddWithValue("p2", int.Parse(txtBolumNo.Text));
            komut1.Parameters.AddWithValue("p3", txtDanisman.Text);
            komut1.Parameters.AddWithValue("p4", txtOgrenciAd.Text);
            komut1.Parameters.AddWithValue("p5", txtOgrenciSoyad.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci ekleme işlemi başarıyla gerçekleşti.");
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from \"Ogrenci\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0] ;
            baglanti.Close();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Ogrenci\" where \"ogrenciNo\"=@p1",baglanti);
            komut2.Parameters.AddWithValue("p1", int.Parse(txtOgrenciNo.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci silme işlemi başarılı bir şekilde gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update \"Ogrenci\" set \"bolumNo\"=@p1,\"danisman\"=@p2 where \"ogrenciNo\"=@p3", baglanti);
            komut3.Parameters.AddWithValue("p1", int.Parse(txtBolumNo.Text));
            komut3.Parameters.AddWithValue("p2", txtDanisman.Text);
            komut3.Parameters.AddWithValue("p3", int.Parse(txtOgrenciNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"Ogrenci\" where \"ad\" like '%" + textBox1.Text + "%'", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;

        }
    }
}
