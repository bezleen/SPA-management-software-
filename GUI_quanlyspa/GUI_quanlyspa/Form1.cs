using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_quanlyspa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

       
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dịj me m cut!!!!");
            this.Close();

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.AliceBlue;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Orange;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dịj me m cut!!!!");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dịj me m cut!!!!");
        }


    }
}
