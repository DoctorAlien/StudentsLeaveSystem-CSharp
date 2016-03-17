//============================================
//Project Name:AskForLeave
//Form Name:AdminX/修改默认管理员密码
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

namespace AskForLeave
{
    public partial class AdminX : Form
    {
        public AdminX()
        {
            InitializeComponent();
        }
        DataBase sql = new DataBase();
        public string sqlString = "";
        private void button1_Click(object sender, EventArgs e)
        {
            common.newMd5Pass = common.md5Create(txtNew.Text);
            common.password = txtNew.Text;

            string newPass = txtNew.Text;
            string newAgain = txtNewAgain.Text;
            sqlString = "select * from user_admin where aid=" + common.number + " and a_password= '" + common.oldMd5Pass + "';";
            sql.upd(sqlString);
            //验证密码的一致性
            if (sql.resultInfo == false)
            {
                tsMessage.Text = "旧密码错误";
            }
            else if (newPass == newAgain)
            {
                sqlString = "update user_admin set a_password='" + common.newMd5Pass + "'where aid=" + common.number;
                sql.InsertData(sqlString);
                tsMessage.Text = "密码修改成功";
                MessageBox.Show(common.newMd5Pass);
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                tsMessage.Text = "新密码重复不一致，请仔细验证！";
            }
        }

        private void AdminX_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
