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
using NHOM12_LTM.Article_information.Trang_Chu;
using NHOM12_LTM.Article_information;

namespace NHOM12_LTM
{
    public partial class Trang_Chu : Form
    {
        private List<string> imageList;         
        private int currentImageIndex = 0;     
        private Timer timerImage;              
        private List<string> articleList;
        private int currentAricleIndex = 0;
        private Timer timerAricle;


        public Trang_Chu()
        {
            InitializeComponent();
            imageList = new List<string>    
            {
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture1.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture2.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture3.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture4.jpg"
            };

            articleList = new List<string>
            {
                 "Ông Trump xuất hiện, khuyên không bán Bitcoin",
                 "Tỉnh nhỏ nhất cả nước dẫn đầu thu hút vốn FDI",
                 "Chùa Cầu 'trẻ hóa' vẫn đúng mục đích trùng tu",
                 "Cá mập cocaine' tràn ngập vùng biển Brazil"
            };

            timerImage = new Timer();
            timerAricle = new Timer();
            try
            {
                timerImage.Tick += timer1_Tick;
                timerAricle.Tick += timer1_Tick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageList.Count > 0 && articleList.Count > 0)                     
            {
                currentImageIndex = (currentImageIndex + 1) % imageList.Count; 
                pic1.Image = Image.FromFile(imageList[currentImageIndex]);
                pic1.ImageLocation = imageList[currentImageIndex];

                currentAricleIndex = (currentAricleIndex + 1) % articleList.Count;
                lblBaiViet.Text = articleList[currentImageIndex].ToString();
            }
        }

        private void Home_News_Load(object sender, EventArgs e)    
        {
            btnTrangChu.BackColor = Color.Yellow;
            timer1.Enabled = true;                     

            if (imageList.Count > 0 && articleList.Count > 0)
            {
                pic1.Image = Image.FromFile(imageList[0]);
                lblBaiViet.Text = articleList[0].ToString();
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
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

        private void pic1_Click(object sender, EventArgs e)
        {
            if (imageList.Count > 0)
            {
                for (int i = 0; i < imageList.Count; i++)
                {
                    if (pic1.ImageLocation == imageList[i]) 
                    {
                        switch (i)
                        {
                            case 0:
                                Open_Picture1();
                                break;

                            case 1:
                                Open_Picture2();
                                break;

                            case 2:
                                Open_Picture3();
                                break;

                            case 3:
                                Open_Picture4();
                                break;
                        }
                        break;
                    }
                }
            }
        }
        private void Open_Picture1()
        {
            string articleContent1 = NHOM12_LTM.Properties.Resources.Content_TT1; 
            Picture1 picture1 = new Picture1(this);
            picture1.displayContent(articleContent1);
            picture1.Show();
            this.Hide();
        }
        private void Open_Picture2()
        {
            string articleContent2 = NHOM12_LTM.Properties.Resources.Content_TT2;
            Picture2 picture2 = new Picture2(this);
            picture2.displayContent(articleContent2);
            picture2.Show();
            this.Hide();
        }

        private void Open_Picture3()
        {
            string articleContent3 = NHOM12_LTM.Properties.Resources.Content_TT3;
            Picture3 picture3 = new Picture3(this);
            picture3.displayContent(articleContent3);
            picture3.Show();
            this.Hide();
        }

        private void Open_Picture4()
        {
            string articleContent4 = NHOM12_LTM.Properties.Resources.Content_TT4;
            Picture4 picture4 = new Picture4(this);
            picture4.displayContent(articleContent4);
            picture4.Show();
            this.Hide();
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            string articleContent5 = NHOM12_LTM.Properties.Resources.Content_TT5;
            Picture5 PT5 = new Picture5(this);
            PT5.displayContent(articleContent5);
            PT5.Show();
            this.Hide();
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            string articleContent6 = NHOM12_LTM.Properties.Resources.Content_TT6;
            Picture6 PT6 = new Picture6(this);
            PT6.displayContent(articleContent6);
            PT6.Show();
            this.Hide();
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            string articleContent7 = NHOM12_LTM.Properties.Resources.Content_TT7;
            Picture7 PT7 = new Picture7(this);
            PT7.displayContent(articleContent7);
            PT7.Show();
            this.Hide();
        }
    }
}

