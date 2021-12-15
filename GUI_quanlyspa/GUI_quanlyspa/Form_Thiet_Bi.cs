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
    public partial class Form_Thiet_Bi : Form
    {

        public Form_Thiet_Bi()
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
            tb_mathietbi.Text = "";
            tb_mancc.Text = "";
            tb_ngaynhap.Text = "";
            tb_nsx.Text = "";
            tb_slnhap.Text = "";
            tb_dvt.Text = "";
            tb_thanhtien.Text = "";
        }
        void taobang(string str)
        {
            //table_thietbi.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            tb_mancc.Enabled = false;
            tb_ngaynhap.Enabled = false;
            tb_nsx.Enabled = false;
            tb_slnhap.Enabled = false;
            tb_dvt.Enabled = false;
            tb_thanhtien.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();
        }
        void enable_box()
        {
            tb_mancc.Enabled = true;
            tb_ngaynhap.Enabled = true;
            tb_nsx.Enabled = true;
            tb_slnhap.Enabled = true;
            tb_dvt.Enabled = true;
            tb_thanhtien.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
        }
        private void Form_Lieu_trinh_Load(object sender, EventArgs e)
        {
            disable_box();
            taobang("");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            //tb_mathietbi.Text = bus.matutang_thietbi("");
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
                if (tb_mathietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                //dto.MATB = tb_mathietbi.Text;
                //bus._deleteData(dto);
                MessageBox.Show("Đã xóa thành công");
                set_null();
                taobang("");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void banglt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_mathietbi.Text = table_thietbi.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_mancc.Text = table_thietbi.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_ngaynhap.Text = table_thietbi.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_nsx.Text = table_thietbi.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_slnhap.Text = table_thietbi.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_dvt.Text = table_thietbi.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_thanhtien.Text = table_thietbi.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void lb_rs_Click(object sender, EventArgs e)
        {
            disable_box();
            set_null();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int i = 0;
            string j;
            if (tb_ngaynhap.Text == "" || tb_nsx.Text == "" || tb_slnhap.Text == "" || tb_thanhtien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(tb_ngaynhap.Text, out i) == false)
            {
                MessageBox.Show("Ngày nhập phải là số");
                return;
            }
            else if (int.TryParse(tb_nsx.Text, out i) == false)
            {
                MessageBox.Show("Ngày sản xuất phải là số");
                return;
            }
            else if (int.TryParse(tb_slnhap.Text, out i) == false)
            {
                MessageBox.Show("Số lượng nhập phải là số");
                return;
            }
            else if (int.TryParse(tb_thanhtien.Text, out i) == false)
            {
                MessageBox.Show("Thành tiền phải là số");
                return;
            }
            try
            {
                //dto.MATB = tb_mathietbi.Text;
                //dto.MANCC = tb_mancc.Text;
                //dto.NGAYNHAP = tb_ngaynhap.Text;
                //dto.NSX = tb_nsx.Text;
                //dto.SLNHAP = tb_slnhap.Text;
                //dto.DVT = tb_dvt.Text;
                //dto.THANHTIENDH = tb_thanhtien.Text;
                //if (themDL == true)
                //{
                //    bus._insertData(dto);
                //    MessageBox.Show("Thêm mới thành công");
                //}
                //else if (themDL == false)
                //{
                //    bus._updateData(dto);
                //    MessageBox.Show("Sửa thành công");
                //}
                set_null();
                disable_box();
                taobang("");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }

        }

        private void lb_Malt_Click(object sender, EventArgs e)
        {

        }

        private void banglt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_TenLT_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_tenlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {

        }
    }
}
