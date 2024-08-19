using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM12_LTM.Article_information.Xa_Hoi
{
    public partial class PictureXH5 : Form
    {
        private Form previousForm;
        public PictureXH5(Form previousNewsForm)
        {
            InitializeComponent();
            this.previousForm = previousNewsForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
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
        public void displayContent(string content)
        {
            rtbPicture5.Text = content;
            //webBrowser1.DocumentText = content;
        }
        //public void displayImage(Bitmap bitmap)
        //{
        //    rtbPicture5.Image = bitmap;
        //}
    }
}
