using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using NHOM12_LTM.Article_information.Xa_Hoi;
using System.Net.NetworkInformation;

namespace NHOM12_LTM
{
    public partial class Xa_Hoi : Form
    {
        public Xa_Hoi()
        {
            InitializeComponent();
        }
        private void Home_News_Load(object sender, EventArgs e)
        {
            btnXaHoi.BackColor = Color.Yellow;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Trang_Chu TC = new Trang_Chu();
            TC.Show();
            this.Hide();
        }

        private void btnTheGioi_Click(object sender, EventArgs e)
        {
            The_Gioi TG = new The_Gioi();
            TG.Show();
            this.Hide();
        }

        private void btnChinhTri_Click(object sender, EventArgs e)
        {
            Chinh_Tri CT = new Chinh_Tri();
            CT.Show();
            this.Hide();
        }

        private void btnPhapLuat_Click(object sender, EventArgs e)
        {
            Phap_Luat PL = new Phap_Luat();
            PL.Show();
            this.Hide();
        }

        private void btnGiaoDuc_Click(object sender, EventArgs e)
        {
            Giao_Duc GD = new Giao_Duc();
            GD.Show();
            this.Hide();
        }

        private void btnCongNghe_Click(object sender, EventArgs e)
        {
            Cong_Nghe CN = new Cong_Nghe();
            CN.Show();
            this.Hide();
        }

        private void btnTheThao_Click(object sender, EventArgs e)
        {
            The_Thao TT = new The_Thao();
            TT.Show();
            this.Hide();
        }

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            Giai_Tri GT = new Giai_Tri();
            GT.Show();
            this.Hide();
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

        private void thếGiớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            The_Gioi TG = new The_Gioi();
            TG.Show();
            this.Hide();
        }

        private void xãHộiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xa_Hoi XH = new Xa_Hoi();
            XH.Show();
            this.Hide();
        }

        private void chínhTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chinh_Tri CT = new Chinh_Tri();
            CT.Show();
            this.Hide();
        }

        private void phápLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phap_Luat PL = new Phap_Luat();
            PL.Show();
            this.Hide();
        }

        private void giáoDụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giao_Duc GD = new Giao_Duc();
            GD.Show();
            this.Hide();
        }

        private void côngNghệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cong_Nghe CN = new Cong_Nghe();
            CN.Show();
            this.Hide();
        }

        private void thểThaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            The_Thao TT = new The_Thao();
            TT.Show();
            this.Hide();
        }

        private void giáiTríToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giai_Tri GT = new Giai_Tri();
            GT.Show();
            this.Hide();
        }

        private void btnXH1_Click(object sender, EventArgs e)
        {
            string articleContent1 = NHOM12_LTM.Properties.Resources.Content_XH1;
            PictureXH1 XH1 = new PictureXH1(this);
            XH1.displayContent(articleContent1);
            XH1.Show();
            this.Hide();
        }

        private void btnXH2_Click(object sender, EventArgs e)
        {
            string articleContent2 = NHOM12_LTM.Properties.Resources.Content_XH2;
            PictureXH2 XH2 = new PictureXH2(this);
            XH2.displayContent(articleContent2);
            XH2.Show();
            this.Hide();
        }

        private void btnXH3_Click(object sender, EventArgs e)
        {
            string articleContent3 = NHOM12_LTM.Properties.Resources.Content_XH3;
            PictureXH3 XH3 = new PictureXH3(this);
            XH3.displayContent(articleContent3);
            XH3.Show();
            this.Hide();
        }

        private void btnXH4_Click(object sender, EventArgs e)
        {
            string articleConten4 = NHOM12_LTM.Properties.Resources.Content_XH4;
            PictureXH4 XH4 = new PictureXH4(this);
            XH4.displayContent(articleConten4);
            XH4.Show();
            this.Hide();
        }

        private void btnXH5_Click(object sender, EventArgs e)
        {
            string articleContent5 = NHOM12_LTM.Properties.Resources.Content_XH5;
            //Bitmap iamgeContent1 = NHOM12_LTM.Properties.Resources.XH1;

            PictureXH5 XH5 = new PictureXH5(this);
            XH5.displayContent(articleContent5);
            //XH5.displayimage(iamgeContent1);
            XH5.Show();
            this.Hide();
        }
    }
}
