//============================================
//Project Name:AskForLeave
//Form Name:ChangePass/修改学生密码
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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        DataBase sql = new DataBase();
        public string sqlString = "";
        /// <summary>
        /// 确定修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //生成md5
            common.newMd5Pass = common.md5Create(txtNew.Text);

            common.password = txtOld.Text;
            string newPass = txtNew.Text;
            string newAgain = txtNewAgain.Text;
            sqlString = "select * from user_student where u_number=" + common.number + " and u_pass= '" + common.oldMd5Pass + "';";
            sql.upd(sqlString);
            //验证密码的一致性
            if (sql.resultInfo == false)
            {
                tsMessage.Text = "旧密码错误";
            }
            else if (newPass == newAgain)
            {
                sqlString = "update user_student set u_pass='" + common.newMd5Pass + "'where uid=" + common.uid;
                sql.InsertData(sqlString);
                tsMessage.Text = "密码修改成功";
                Login login = new Login();
                login.Show();
                this.Close();    
            }
            else
            {
                tsMessage.Text = "新密码重复不一致，请仔细验证！";
            }
        }
        private void cpClose(object sender, FormClosedEventArgs e)
        {}

        private void cpCloseing(object sender, FormClosingEventArgs e)
        {}
        /// <summary>
        /// 取消修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Close();     
        }
    }
}
