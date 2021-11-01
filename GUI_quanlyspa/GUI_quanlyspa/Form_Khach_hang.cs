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
    public partial class Form_Khach_hang : Form
    {
        public Form_Khach_hang()
        {
            InitializeComponent();
        }
        //code nut exit 
        private void picBox_iconExit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }
        // code hover cho cac module
        private void pnl_Home_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.YellowGreen;
        }

        private void pnl_Home_MouseLeave(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.Orange;
        }

        private void pnl_Nhanvien_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.YellowGreen;
        }

        private void pnl_Nhanvien_MouseLeave(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.Orange;
        }

        private void pnl_Mypham_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.YellowGreen;
        }

        private void pnl_Mypham_MouseLeave(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.Orange;
        }

        private void pnl_Khachhang_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.YellowGreen;
        }

        private void pnl_Khachhang_MouseLeave(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.Orange;
        }

        private void pnl_Thietbi_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.YellowGreen;
        }

        private void pnl_Thietbi_MouseLeave(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.Orange;
        }

        private void pnl_Hoadon_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.YellowGreen;
        }

        private void pnl_Hoadon_MouseLeave(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.Orange;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.YellowGreen;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.YellowGreen;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.YellowGreen;
        }


        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.YellowGreen;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.YellowGreen;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.YellowGreen;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.YellowGreen;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.YellowGreen;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.YellowGreen;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.YellowGreen;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.YellowGreen;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.YellowGreen;
        }
        //ketthuc
        //code chuyen tab cho cac module
        private void pnl_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home();
            obj.Show();
            this.Hide();
        }

        private void Form_Khach_hang_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //ket thuc

    }
}
