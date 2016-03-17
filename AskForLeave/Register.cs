//============================================
//Project Name:AskForLeave
//Form Name:Register/学生注册
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
using System.Threading;
using System.Text.RegularExpressions;

namespace AskForLeave
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        DataBase sql = new DataBase();
        DataSet teaComb = null;
        DataSet classComb = null;
        public string sqlString = "";
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int stuNumber = int.Parse(txtNumber.Text);
                string stuName = txtName.Text;
                string stuPass = common.md5Create(txtPassword.Text);
                string stuClass = combClass.SelectedValue.ToString();
                int stuTea = combTeacher.SelectedIndex + 1;

                //正则初次判断 用户名密码的准确性
                Regex regex1 = new Regex(@"^[0-9]{7}$");
                if (regex1.Match(txtNumber.Text).Success == false)
                {
                    tsMessage.Text = "学号格式错误";
                }
                else 
                {
                    Regex regex2 = new Regex(@"^[0-9a-zA-Z]{6,16}$");
                    if (regex2.Match(txtPassword.Text).Success == false)
                    {
                        tsMessage.Text = "密码长度不正确";
                    }
                    else
                    {
                        tsMessage.Text = "密码规则验证正确，请稍后！";
                        sqlString = "insert into user_student (u_number,u_name,u_class,u_pass,tid) values(" + stuNumber + ",'" + stuName + "','" + stuClass + "','"+stuPass+"'," + stuTea + ")";
                        sql.InsertData(sqlString);
                        tsMessage.Text = "注册成功！正在跳转……";
                        Thread.Sleep(1500);
                        tsMessage.Text = "注册成功！正在跳转……";
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                tsMessage.Text = "请检查输入的准确性！";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            //默认combTeacher加载数据
            sqlString = "select tid,t_name from user_teacher";
            teaComb = sql.GetDataSet(sqlString);
            combTeacher.DataSource = teaComb.Tables[0];
            combTeacher.DisplayMember = "t_name";
            combTeacher.ValueMember = "tid";
            combTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            //默认combClass加载数据
            sqlString = "select distinct u_class from user_student";
            classComb = sql.GetDataSet(sqlString);
            combClass.DataSource = classComb.Tables[0];
            combClass.DisplayMember = "u_class";
            combClass.ValueMember = "u_class";
        }
    }
}
