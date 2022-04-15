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
using System.IO;
using System.Collections;
using System.Threading;
namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string kad, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Form1 frm1 = new Form1();
            
        ArrayList arr = new ArrayList();
            OleDbDataReader dr;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from kullanici where k_ad='" + textBox1.Text + "' and k_sifre='" + textBox2.Text + "'",baglanti);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Kullanıcı Giriş Başarılı Yönlendiriliyorsunuz");
                kad=textBox1.Text;
                baglanti.Close();
                frm1.Close();
                frm.Show();
               
            }
            else
            {
                
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                baglanti.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris.accdb");
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("insert into kullanici (k_ad,k_sifre) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı Giriş Yapabilirsiniz");
            baglanti.Close();
        }
    }
}
