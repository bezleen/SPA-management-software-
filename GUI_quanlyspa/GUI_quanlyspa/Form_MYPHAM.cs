using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using quanlyspa_DTO;
using BUS_quanlyspa;

namespace GUI_quanlyspa
{
    public partial class Form_MYPHAM : Form
    {
        BUS_MYPHAM bus = new BUS_MYPHAM();
        DTO_MYPHAM dto = new DTO_MYPHAM();
        public Form_MYPHAM()
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
        //code chuyen tab cho cac module
        private void pnl_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home();
            obj.Show();
            this.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home();
            obj.Show();
            this.Hide();
        }
        //ket thuc

        //code chuc nang
        bool themDL;
        void set_null()
        {
            txtbox_chungloai.Text = "";
            txtbox_giaban.Text = "";
            txtbox_hamluong.Text = "";
            txtbox_Mamp.Text = "";
            txtbox_sltk.Text = "";
            txtbox_tenmp.Text = "";

        }
        void Taobang(string str)
        {
            bangmp.DataSource = bus._selectData(str);
        }

        void disable_box()
        {
            txtbox_sltk.Enabled = false;
            txtbox_tenmp.Enabled = false;
            txtbox_hamluong.Enabled = false;
            txtbox_giaban.Enabled = false;
            txtbox_chungloai.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();

        }

        void enable_box()
        {
            txtbox_sltk.Enabled = true;
            txtbox_tenmp.Enabled = true;
            txtbox_hamluong.Enabled = true;
            txtbox_giaban.Enabled = true;
            txtbox_chungloai.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
        }

        private void Form_Mypham_Load(object sender, EventArgs e)
        {
            disable_box();
            Taobang("");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            txtbox_Mamp.Text = bus.matutang_mypham("");
            themDL = true;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();

            themDL = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_Mamp.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                dto.MAMP = txtbox_Mamp.Text;
                bus._deleteData(dto);
                MessageBox.Show("Đã xóa thành công");
                set_null();
                Taobang("");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        //code nut reset 
        private void lb_rs_Click(object sender, EventArgs e)
        {
            disable_box();
            set_null();
        }
        private void banglt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_Mamp.Text = bangmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbox_tenmp.Text = bangmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbox_chungloai.Text = bangmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbox_hamluong.Text = bangmp.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbox_sltk.Text = bangmp.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbox_giaban.Text = bangmp.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtbox_tenmp.Text == "" || txtbox_chungloai.Text == "" || txtbox_hamluong.Text == "" || txtbox_sltk.Text == "" || txtbox_giaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(txtbox_chungloai.Text, out i) == false)
            {
                MessageBox.Show("Vui lòng nhập lại chủng loại");
                return;
            }
            else if (int.TryParse(txtbox_hamluong.Text, out i) == false)
            {
                MessageBox.Show("Hàm lượng phải là số");
                return;
            }
            else if (int.TryParse(txtbox_giaban.Text, out i) == false)
            {
                MessageBox.Show("Gía bán phải là số");
                return;
            }

            try
            {
                dto.MAMP = txtbox_Mamp.Text;
                dto.TENMP = txtbox_Mamp.Text;
                dto.CHUNGLOAI = txtbox_chungloai.Text;
                dto.HAMLUONG = txtbox_hamluong.Text;
                dto.GIABAN = txtbox_giaban.Text;
                if (themDL == true)
                {
                    bus._insertData(dto);
                    MessageBox.Show("Thêm mới thành công");
                }
                else if (themDL == false)
                {
                    bus._updateData(dto);
                    MessageBox.Show("Sửa thành công");
                }
                set_null();
                disable_box();
                Taobang("");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }

        }

        private void Form_MYPHAM_Load_1(object sender, EventArgs e)
        {

        }

        private void pnl_workplace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Lieutrinh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

