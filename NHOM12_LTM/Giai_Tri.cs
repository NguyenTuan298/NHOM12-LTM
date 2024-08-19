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
using NHOM12_LTM.Article_information.Giai_Tri;

namespace NHOM12_LTM
{
    public partial class Giai_Tri : Form
    {
        public Giai_Tri()
        {
            InitializeComponent();
        }
        private void Home_News_Load(object sender, EventArgs e)
        {
            btnGiaiTri.BackColor = Color.Yellow;
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

        private void btnXaHoi_Click(object sender, EventArgs e)
        {
            Xa_Hoi XH = new Xa_Hoi();
            XH.Show();
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

        private void btnGT1_Click(object sender, EventArgs e)
        {
            string articleContent1 = NHOM12_LTM.Properties.Resources.Content_GT1;
            PictureGT1 gT1 = new PictureGT1(this);
            gT1.displayContent(articleContent1);
            gT1.Show();
            this.Hide();
        }

        private void btnGT2_Click(object sender, EventArgs e)
        {
            string articleContent2 = NHOM12_LTM.Properties.Resources.Content_GT2;
            PictureGT2 gT2 = new PictureGT2(this);
            gT2.displayContent(articleContent2);
            gT2.Show();
            this.Hide();
        }

        private void btnGT3_Click(object sender, EventArgs e)
        {
            string articleContent3 = NHOM12_LTM.Properties.Resources.Content_GT3;
            PictureGT3 gT3 = new PictureGT3(this);
            gT3.displayContent(articleContent3);
            gT3.Show();
            this.Hide();
        }

        private void btnGT4_Click(object sender, EventArgs e)
        {
            string articleContent4 = NHOM12_LTM.Properties.Resources.Content_GT4;
            PictureGT4 gT4 = new PictureGT4(this);
            gT4.displayContent(articleContent4);
            gT4.Show();
            this.Hide();
        }

        private void btnGT5_Click(object sender, EventArgs e)
        {
            string articleContent5 = NHOM12_LTM.Properties.Resources.Content_GT5;
            PictureGT5 gT5 = new PictureGT5(this);
            gT5.displayContent(articleContent5);
            gT5.Show();
            this.Hide();
        }
    }
}
