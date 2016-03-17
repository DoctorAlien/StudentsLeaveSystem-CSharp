//============================================
//Project Name:AskForLeave
//Form Name:md5Create/MD5生成器
//Author:DoctorAlien
//Date:2015/12/31
//============================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AskForLeave
{
    public partial class md5Create : Form
    {
        public md5Create()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtMD5.Text=common.md5Create(txtString.Text);
        }

        private void md5Create_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
