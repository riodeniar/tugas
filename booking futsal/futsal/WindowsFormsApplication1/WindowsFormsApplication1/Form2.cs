using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Data_Petugas : Form
    {
        private string tgl, username, pass, telepon, alamat ;

        public Data_Petugas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form3().Show();
            //this.Hide();

            tgl = tanggal1.Text;
            username = username2.Text;
            pass = pass3.Text;
            telepon = telepon4.Text;
            alamat = alamat5.Text;

            textBoxhasil.Text = "Tanggal   : " + tgl
                + "\nUsername  : " + username 
                + "\nPassword   : " + pass
                + "\nTelepon    : " + telepon
                + "\nAlamat     : " + alamat;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxhasil.Text = string.Empty;
        }
    }
}
