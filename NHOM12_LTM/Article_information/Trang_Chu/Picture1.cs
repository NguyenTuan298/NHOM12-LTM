using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM12_LTM.Article_information.Trang_Chu
{
    public partial class Picture1 : Form
    {
        private Form previousForm;  // form: kiểu dữ liệu ( lớp cơ sở của tất cả các form ), previousForm: tên của biến thành viên
        public Picture1(Form previousNewsForm)   // Tham số:previousNewsForm (biểu mẫu tin tức trước đó),  đối tượng: Form, đại diện cho form trước đó mà bạn muốn lưu giữ
        {
            InitializeComponent();
            this.previousForm = previousNewsForm;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Thông Báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();   // mở lại form trước đó 
            this.Close();               // Đóng form hiện tại
        }

        // Phương thức này nhận nội dung bài viết và hiển thị nó trong rtbPicture1
        public void displayContent(string content)      
        {
            rtbPicture1.Text = content; 
            //webBrowser1.DocumentText = content;
        }
    }
}
