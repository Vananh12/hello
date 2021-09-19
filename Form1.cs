using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_UserName.Focus();
            txt_PassWord.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap()
        {
            if (txt_UserName.Text.Length == 0 && txt_PassWord.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập Password nha!");
            else
                if (this.txt_UserName.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập Username nha!");
            else
                if (this.txt_PassWord.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập Password nha!");
            else
                if (this.txt_UserName.Text == "phamvananh" && this.txt_PassWord.Text == "1234567")
                MessageBox.Show("Đăng nhập thành công rồi nha!");
            else
                MessageBox.Show("Mật khẩu hoặc tên người dùng không đúng, vui lòng thử lại!");
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            if(this.txt_UserName.Text == "phamvananh" && this.txt_PassWord.Text == "1234567")
            {
                fm.Show();
            }
            dangnhap();
        }
    }
}
