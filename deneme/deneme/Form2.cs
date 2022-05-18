using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace deneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=gorselprogram;Integrated Security=True");
            baglantı.Open();
           
            SqlCommand kayıtolustur = new SqlCommand("insert into musterikabul(Musterino,İsim,Soyisim,Telno,Dogumtarih,Ucret) values(@m1,@m2,@m3,@m4,@m5,@m6)",baglantı);
            kayıtolustur.Parameters.AddWithValue("@m1", textBox1.Text);
            kayıtolustur.Parameters.AddWithValue("@m2", textBox2.Text);
            kayıtolustur.Parameters.AddWithValue("@m3", textBox3.Text);
            kayıtolustur.Parameters.AddWithValue("@m4", textBox4.Text);
            kayıtolustur.Parameters.AddWithValue("@m5", textBox5.Text);
            kayıtolustur.Parameters.AddWithValue("@m6", textBox6.Text);
            kayıtolustur.ExecuteNonQuery();
            baglantı.Close();
        }
    }
}
