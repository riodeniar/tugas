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
    public partial class Form3 : Form
    {
        private string id_ptgs, nama_petugas, tgl, no_boking, boking_jam, nama_tim, tlp, hrg, dp1, sisa_bayar;

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double bayar = double.Parse(harga8.Text);
            double dp = double.Parse(dp9.Text);
            sisabayar10.Text = (bayar - dp).ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form4().Show();
            //this.Hide();

            id_ptgs = idpetugas1.Text;
            nama_petugas = namapetugas2.Text;
            tgl = tanggal3.Text;
            no_boking = noboking4.Text;
            boking_jam = bokingjam5.Text;
            nama_tim = namatim6.Text;
            tlp = telepon7.Text;
            hrg = harga8.Text;
            dp1 = dp9.Text;
            sisa_bayar = sisabayar10.Text;

            tbhasil.Text = "ID PETUGAS    : " + id_ptgs
                + "\nNama Petugas   : " + nama_petugas
                + "\nTanggal   : " + tgl
                + "\nNomor Boking    : " + no_boking
                + "\nBoking Jam    : " + boking_jam
                + "\nNama Tim   : " + nama_tim
                + "\nTelepon    : " + tlp
                + "\nHarga    : " + hrg
                + "\nDp   : " + dp1
                + "\nSisa Bayar    : " + sisa_bayar;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbhasil.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           boking_jam = bokingjam5.Text;
           double harga = double.Parse(bokingjam5.Text);
           harga8.Text = (harga * 75000).ToString() ;
           
               
            
        }
    }
}
