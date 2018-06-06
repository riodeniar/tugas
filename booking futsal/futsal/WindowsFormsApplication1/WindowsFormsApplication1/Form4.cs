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
    public partial class Form4 : Form
    {
        private string idptgas, nmptgas, tnggal, nmember, nmtim, rbtnsiang, rbtnmalam, ntlp, byar, kmblian ;

        public Form4()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbsiang.Show();
            tbsiang.Show();
            rbmalam.Hide();
            tbmalam.Hide();
        }

        private void rbmalam_CheckedChanged(object sender, EventArgs e)
        {
            rbsiang.Hide();
            tbsiang.Hide();
            rbmalam.Show();
            tbmalam.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idptgas = tbptg.Text;
            nmptgas = tbnamaptgs.Text;
            tnggal = dtptgl.Text;
            nmember = tbmember.Text;
            nmtim = tbtim.Text;
            rbtnsiang = tbsiang.Text;
            rbtnmalam = tbmalam.Text;
            ntlp = tbtlp.Text;
            byar = tbbayar.Text;
            kmblian = tbkembalian.Text;


            textBoxhasil.Text = "ID Petugas   : " + idptgas
                + "\n\nNama Petugas   : " + nmptgas
                + "\nTanggal   : " + tnggal 
                + "\n\nNo Member    : " + nmember
                + "\nNama Tim   : " + nmtim
                + "\nSiang   : " + rbtnsiang
                + "\nMalam    : " + rbtnmalam
                + "\nNo Telepon   : " + ntlp
                + "\nBayar   : " + byar
                + "\nKembalian    : " + kmblian;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxhasil.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbsiang.Checked)
                    tbsiang.Text = (50000).ToString();
                else 
                     tbmalam.Text = (100000).ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbsiang.Checked == true)
                {
                   
                    double bayar = double.Parse(tbbayar.Text);
                    double siang = double.Parse(tbsiang.Text);
                    tbkembalian.Text = (bayar - siang).ToString();
                }
                else
                {
                   
                    double bayar = double.Parse(tbbayar.Text);
                    double malam = double.Parse(tbmalam.Text);
                    tbkembalian.Text = (bayar - malam).ToString();
                }
            }
            catch
            {

            }

                
        }
    }
}
