﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM12_LTM.Article_information.Giai_Tri
{
    public partial class PictureGT3 : Form
    {
        private Form previousForm;
        public PictureGT3(Form previousNewsForm)
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
            rtxPictureGT3.Text = content;
        }
    }
}
