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
using NHOM12_LTM.Article_information.Giao_Duc;

namespace NHOM12_LTM
{
    public partial class Giao_Duc : Form
    {
        public Giao_Duc()
        {
            InitializeComponent();
        }
        private void Home_News_Load(object sender, EventArgs e)
        {
            btnGiaoDuc.BackColor = Color.Yellow;
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

        private void btnGD1_Click(object sender, EventArgs e)
        {
            PictureGD1 gD1 = new PictureGD1(this);
            gD1.Show();
            this.Hide();
        }

        private void btnGD2_Click(object sender, EventArgs e)
        {
            PictureGD2 gD2 = new PictureGD2(this);
            gD2.Show();
            this.Hide();
        }

        private void btnGD3_Click(object sender, EventArgs e)
        {
            PictureGD3 gD3 = new PictureGD3(this);
            gD3.Show();
            this.Hide();
        }

        private void btnGD4_Click(object sender, EventArgs e)
        {
            PictureGD4 gD4 = new PictureGD4(this);
            gD4.Show();
            this.Hide();
        }

        private void btnGD5_Click(object sender, EventArgs e)
        {
            PictureGD5 gD5 = new PictureGD5(this);
            gD5.Show();
            this.Hide();
        }
    }
}
