using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM12_LTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn chắc chắn muốn thoát chương trình không?",
                "Thông Báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Cảm ơn Bạn đã sử dụng ứng dụng của chúng tôi!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";  // xóa thông tin đã nhập về khoảng trắng 
            txtPassword.Text = ""; // xóa thông tin đã nhập về khoảng trắng 
        }

        private void btnLoGin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // xóa toàn bộ thông báo lỗi khi bắt đầu chạy
            if (txtUserName.Text == "")
                errorProvider1.SetError(txtUserName, "Bạn chưa nhập tên đăng nhập");

            int password = 0;
            if(txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword,"Bạn chưa nhập mật khẩu");
            }
            else if (int.TryParse(txtPassword.Text, out password) == false)
            {
                errorProvider1.SetError(txtPassword, "sai định dạng password");
            }
            else
            {
                if (password != 112233 )
                    errorProvider1.SetError(txtPassword, "Bạn nhập sai mật khẩu");
            }

            Home_News HN = new Home_News();
            HN.Show();
            this.Hide();
        }

        private void chkShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassWord.Checked == true)            // khi người dùng click vào 
                txtPassword.UseSystemPasswordChar = false; // cho phép hiển thị mật khẩu
            else
                txtPassword.UseSystemPasswordChar = true;  // Ẩn mật khẩu
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
