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
using NHOM12_LTM.Article_information.The_Gioi;

namespace NHOM12_LTM
{
    public partial class The_Gioi : Form
    {
        public The_Gioi()
        {
            InitializeComponent();
        }
        private void Home_News_Load(object sender, EventArgs e)
        {
            btnTheGioi.BackColor = Color.Yellow;
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

        private void btnXaHoi_Click(object sender, EventArgs e)
        {
            Xa_Hoi XH = new Xa_Hoi();
            XH.Show();
            this.Hide();
            btnXaHoi.BackColor = Color.Yellow;
        }

        private void btnChinhTri_Click(object sender, EventArgs e)
        {
            Chinh_Tri CT = new Chinh_Tri();
            CT.Show();
            this.Hide();
            btnChinhTri.BackColor = Color.Yellow;
        }

        private void btnPhapLuat_Click(object sender, EventArgs e)
        {
            Phap_Luat PL = new Phap_Luat();
            PL.Show();
            this.Hide();
            btnPhapLuat.BackColor = Color.Yellow;
        }

        private void btnGiaoDuc_Click(object sender, EventArgs e)
        {
            Giao_Duc GD = new Giao_Duc();
            GD.Show();
            this.Hide();
            btnGiaoDuc.BackColor = Color.Yellow;
        }

        private void btnCongNghe_Click(object sender, EventArgs e)
        {
            Cong_Nghe CN = new Cong_Nghe();
            CN.Show();
            this.Hide();
            btnCongNghe.BackColor = Color.Yellow;
        }

        private void btnTheThao_Click(object sender, EventArgs e)
        {
            The_Thao TT = new The_Thao();
            TT.Show();
            this.Hide();
            btnTheThao.BackColor = Color.Yellow;
        }

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            Giai_Tri GT = new Giai_Tri();
            GT.Show();
            this.Hide();
            btnGiaiTri.BackColor = Color.Yellow;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Thông Báo!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
                Close();
        }

        // contextMenuTrip
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

        private void btnTG1_Click(object sender, EventArgs e)
        {
            PictureTG1 TG1 = new PictureTG1(this);
            TG1.Show();
            this.Hide();
        }

        private void btnTG2_Click(object sender, EventArgs e)
        {
            PictureTG2 TG2 = new PictureTG2(this);
            TG2.Show();
            this.Hide();
        }

        private void btnTG3_Click(object sender, EventArgs e)
        {
            PictureTG3 TG3 = new PictureTG3(this);
            TG3.Show();
            this.Hide();
        }

        private void btnTG4_Click(object sender, EventArgs e)
        {
            PictureTG4 TG4 = new PictureTG4(this);
            TG4.Show();
            this.Hide();
        }

        private void btnTG5_Click(object sender, EventArgs e)
        {
            PictureTG5 TG5 = new PictureTG5(this);
            TG5.Show();
            this.Hide();
        }
    }
}
