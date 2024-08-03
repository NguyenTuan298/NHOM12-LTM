﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NHOM12_LTM
{
    public partial class Home_News : Form
    {
        // Image
        private List<string> imageList;         // khai báo một danh sách để lưu trữ các hình ảnh
        private int currentImageIndex = 0;      // khai báo 1 biến để theo dõi ảnh hiện tại đang hiển thị
        private Timer timerImage;               // Khai báo một đối tượng Timer để thay đổi hình ảnh.
        // Aricle 
        private List<string> articleList;
        private int currentAricleIndex = 0;
        private Timer timerAricle;


        public Home_News()
        {
            InitializeComponent();
            imageList = new List<string>        // khởi tạo danh sách đường dẫn của các hình ảnh
            {
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture1.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture2.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture3.jpg",
                "C:\\NHOM12_LTM\\DỰ ÁN CHUNG\\NHOM12-LTM\\NHOM12_LTM\\picture\\picture4.jpg"
            };
            //timerImage = new Timer();         // khởi tạo đối tượng Timer
            //timerImage.Interval = 5000;       // không cần đoạn này cũng dc vì trên form đã thiết kế sẵn 
            //timerImage.Tick += timer1_Tick;

            articleList = new List<string>                                       
            {
                 "Ông Trump xuất hiện, khuyên không bán Bitcoin", 
                 "Tỉnh nhỏ nhất cả nước dẫn đầu thu hút vốn FDI",
                 "Chùa Cầu 'trẻ hóa' vẫn đúng mục đích trùng tu",
                 "Cá mập cocaine' tràn ngập vùng biển Brazil"
            };

            timerImage = new Timer(); 
            timerAricle = new Timer();
            //timerAricle.Interval = 5000;
            //timerAricle.Tick += timer1_Tick;
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
            if (imageList.Count > 0 && articleList.Count > 0)                     // kiểm tra xem "imageList" and "articleList" có hay không
            {
                currentImageIndex = (currentImageIndex + 1) % imageList.Count;   // Tăng chỉ số hình ảnh hiện tại lên một
                pic1.Image = Image.FromFile(imageList[currentImageIndex]);      // Tải hình ảnh mới từ đường dẫn và hiển thị nó trong PictureBox.
                currentAricleIndex = (currentAricleIndex + 1) % articleList.Count;
                lblBaiViet.Text = articleList[currentImageIndex].ToString();
            }
        }

        private void Home_News_Load(object sender, EventArgs e)     // form chính
        {
            btnTrangChu.BackColor = Color.Yellow;       // khai báo màu khi chương trình bắt đầu
            timer1.Enabled = true;                      // bắt đầu chạy (ko dừng nếu giá trị đó đặt là false ) và kích hoạt sự kiện 'Tick' theo khoảng thời gian 'interval'

            if (imageList.Count > 0 && articleList.Count > 0)
            {
                pic1.Image = Image.FromFile(imageList[0]);      
                lblBaiViet.Text = articleList[0].ToString();
            }
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
            else
                MessageBox.Show("Mời bạn sử dụng tiếp chương trình");
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

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            Giai_Tri GT = new Giai_Tri();
            GT.Show();
            this.Hide();
        }
    }
}
    