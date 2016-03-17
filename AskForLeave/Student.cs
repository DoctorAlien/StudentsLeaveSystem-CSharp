//============================================
//Project Name:AskForLeave
//Form Name:Student/学生信息界面
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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        public DataSet ds = null;
        DataBase sql = new DataBase();
        public string sqlString = null;

        private void Student_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //textbox默认不可编辑，背景色为白色
            txtName.ReadOnly = true;
            txtName.BackColor = Color.White;
            txtNum.ReadOnly = true;
            txtNum.BackColor = Color.White;
            txtClass.ReadOnly = true;
            txtClass.BackColor = Color.White;
            txtTeacher.ReadOnly = true;
            txtTeacher.BackColor = Color.White;

            //加载数据至 Textbox
            sqlString = "select *,t_name from user_student as us,user_teacher as ut where u_number="+common.number+" and us.tid=ut.tid";
            ds = sql.GetDataSet(sqlString); 
            txtNum.Text = common.number;    //学生学号
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();//学生姓名
            txtClass.Text = ds.Tables[0].Rows[0][3].ToString();//学生班级
            txtTeacher.Text = ds.Tables[0].Rows[0][7].ToString();//辅导员
            //存储uid
            common.uid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            
        }
        /// <summary>
        /// 提交假单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //判断是否为默认密码
            if (common.password == "123456")
            {
                MessageBox.Show("请及时修改初始密码！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tsMessage.Text = "请及时修改初始密码！";
            }
            //判断假条长度是否超过限制
            if (txtLeave.TextLength < 250)
            {
                sqlString = "insert into leave_ticket (uid,u_message,create_date,expiration_date) values(" + common.uid + ",'" + txtLeave.Text + "','" + startTime.Value.ToShortDateString() + "','" + endTime.Value.ToShortDateString() + "')";
                sql.InsertData(sqlString);
                tsMessage.Text = "请假条提交成功！";
                startTime.Value = DateTime.Now;
                endTime.Value = DateTime.Now;
                txtLeave.Text = "";
            }
            else
            {
                tsMessage.Text = "超过限制！";
            } 
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            startTime.Value = DateTime.Now;
            endTime.Value = DateTime.Now;
            txtLeave.Text = "";
        }
        /// <summary>
        /// 查看已提交的假条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            leaveHistory leave = new leaveHistory();
            leave.Show();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Show();
            this.Hide();
        }
        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stuClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        
    }
}
