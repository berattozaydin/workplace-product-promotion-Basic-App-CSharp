using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label13.Text = Form1.kad;
        }

        public void deterjan(object sender, EventArgs e)
        {
            label10.Text = label2.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from deterjan",baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        public void sarkuteri(object sender,EventArgs e)
        {
            label10.Text = label3.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from sarkuteri", baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void kozmetik(object sender, EventArgs e)
        {
            label10.Text = label4.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from kozmetik", baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void gidaurun(object sender, EventArgs e)
        {
            label10.Text = label5.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from gidaurun", baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void vucut(object sender, EventArgs e)
        {
            label10.Text = label6.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vucutbakim", baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void manav(object sender, EventArgs e)
        {
            label10.Text = label7.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris2.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("select * from manav", baglanti);
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void DataGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label11.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıldı Program Kapatılıyor...");
            Thread.Sleep(2000);
            Application.Exit();
        }
    }
}
