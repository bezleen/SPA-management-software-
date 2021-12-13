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
    public partial class Form_Lieu_trinh : Form
    {
        BUS_LieuTrinh bus = new BUS_LieuTrinh();
        DTO_LieuTrinh dto = new DTO_LieuTrinh();
        public Form_Lieu_trinh()
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
            txtbox_Malt.Text = "";
            txtbox_tenlt.Text = "";
            txtbox_tg.Text = "";
            txtbox_giatien.Text = "";
        }
        void taobang(string str)
        {
            banglt.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            txtbox_tenlt.Enabled = false;
            txtbox_tg.Enabled = false;
            txtbox_giatien.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();
        }
        void enable_box()
        {
            txtbox_tenlt.Enabled = true;
            txtbox_tg.Enabled = true;
            txtbox_giatien.Enabled = true;

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
            txtbox_Malt.Text = bus.matutang_lieutrinh("");
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
                if (txtbox_Malt.Text=="")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                dto.MALT = txtbox_Malt.Text;
                bus._deleteData(dto);
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
                txtbox_Malt.Text = banglt.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbox_tenlt.Text = banglt.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbox_tg.Text = banglt.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbox_giatien.Text = banglt.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            if (txtbox_tenlt.Text==""||txtbox_giatien.Text==""||txtbox_tg.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(txtbox_tg.Text, out i)==false)
            {
                MessageBox.Show("Thời gian phải là số");
                return;
            }
            else if (int.TryParse(txtbox_giatien.Text, out i) == false)
            {
                MessageBox.Show("Giá tiền phải là số");
                return;
            }
            try
            {
                dto.MALT = txtbox_Malt.Text;
                dto.TENLT = txtbox_tenlt.Text;
                dto.THOIGIANDT = txtbox_tg.Text;
                dto.GIATIEN = txtbox_giatien.Text;
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
                taobang("");     
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }

        }

        private void txtbox_Malt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_input_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_Malt_Click(object sender, EventArgs e)
        {

        }

        private void lb_TenLT_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_tenlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_tg_TextChanged(object sender, EventArgs e)
        {

        }
    }
    // còn thieu: pnl logout, chuyen tab
}
