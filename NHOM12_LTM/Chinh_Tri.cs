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
using NHOM12_LTM.Article_information.Chinh_Tri;

namespace NHOM12_LTM
{
    public partial class Chinh_Tri : Form
    {
        public Chinh_Tri()
        {
            InitializeComponent();
        }
        private void Home_News_Load(object sender, EventArgs e)
        {
            btnChinhTri.BackColor = Color.Yellow;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            The_Gioi TG = new The_Gioi();
            TG.Show();
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
            if( result == DialogResult.Yes )
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

        private void btnCT1_Click(object sender, EventArgs e)
        {
            string articleContent1 = NHOM12_LTM.Properties.Resources.Content_CT1;
            PictureCT1 cT1 = new PictureCT1(this);
            cT1.displayContent(articleContent1);
            cT1.Show();
            this.Hide();
        }

        private void btnCT2_Click(object sender, EventArgs e)
        {
            string articleContent2 = NHOM12_LTM.Properties.Resources.Content_CT2;
            PictureCT2 cT2 = new PictureCT2(this);
            cT2.displayContent(articleContent2);
            cT2.Show();
            this.Hide();
        }

        private void btnCT3_Click(object sender, EventArgs e)
        {
            string articleContent3 = NHOM12_LTM.Properties.Resources.Content_CT3;
            PictureCT3 cT3 = new PictureCT3(this);
            cT3.displayContent(articleContent3);
            cT3.Show();
            this.Hide();
        }

        private void btnCT4_Click(object sender, EventArgs e)
        {
            string articleContent4 = NHOM12_LTM.Properties.Resources.Content_CT4;
            PictureCT4 cT4 = new PictureCT4(this);
            cT4.displayContent(articleContent4);
            cT4.Show();
            this.Hide();
        }

        private void btnCT5_Click(object sender, EventArgs e)
        {
            string articleContent5 = NHOM12_LTM.Properties.Resources.Content_CT5;
            PictureCT5 cT5 = new PictureCT5(this);
            cT5.displayContent(articleContent5);
            cT5.Show();
            this.Hide();
        }
    }
}
