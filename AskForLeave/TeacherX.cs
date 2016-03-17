//============================================
//Project Name:AskForLeave
//Form Name:TeacherX/教师修改密码界面
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
    public partial class TeacherX : Form
    {
        public TeacherX()
        {
            InitializeComponent();
        }

        private void TeacherX_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        DataBase sql = new DataBase();
        public string sqlString = "";
        private void btnX_Click(object sender, EventArgs e)
        {
            common.newMd5Pass = common.md5Create(txtNew.Text);
            common.password = txtNew.Text;

            string newPass = txtNew.Text;
            string newAgain = txtNewAgain.Text;
            sqlString = "select * from user_teacher where tid=" + common.number + " and t_password= '" + common.oldMd5Pass + "';";
            sql.upd(sqlString);
            //验证密码的一致性
            if (sql.resultInfo == false)
            {
                tsMessage.Text = "旧密码错误";
            }
            else if (newPass == newAgain)
            {
                sqlString = "update user_teacher set t_password='" + common.newMd5Pass + "'where tid=" + common.number;
                sql.InsertData(sqlString);
                tsMessage.Text = "密码修改成功";
                //MessageBox.Show(common.newMd5Pass);
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                tsMessage.Text = "新密码重复不一致，请仔细验证！";
            }
        }
    }
}
