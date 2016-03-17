//============================================
//Project Name:AskForLeave
//Form Name:Login/登陆界面
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
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace AskForLeave
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //引用IrisSkin.dll文件 美化程序
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
            skin.SkinFile = System.Environment.CurrentDirectory  + "//image//MacOS.ssk";
            skin.Active = true;
        }

        public string sqlString = null;
        DataBase sql = new DataBase();
        public DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //默认选中学生
            rbStu.Checked = true;
            //窗体加载头像
            pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\image\face.png");
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox2.ClientRectangle);
            Region region = new Region(gp);
            pictureBox2.Region = region;
            gp.Dispose();
            region.Dispose();
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //combox添加选项 Version 0.6中已废除
            //combGroup.Items.Add("学生");
            //combGroup.Items.Add("教师");
            //combGroup.Items.Add("管理员");
            //combGroup.SelectedIndex = 0;//默认选中学生
            //combGroup.DropDownStyle = ComboBoxStyle.DropDownList;//默认不可以编辑，只能选择
            txtPassword.PasswordChar=(Convert.ToChar("*"));//设置密码输入框默认字符为*

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                tsMessage.Text = "";
                common.number = txtNum.Text;
                common.password = txtPassword.Text;

                //生成MD5
                common.oldMd5Pass = common.md5Create(common.password);
                
                //正则初次判断 用户名密码的准确性
                Regex regex1 = new Regex(@"^[0-9]{7}$");
                if (regex1.Match(txtNum.Text).Success == false)
                {
                    tsMessage.Text = "学号错误";
                }
                Regex regex2 = new Regex(@"^[0-9a-zA-Z]{6,16}$");
                if (regex2.Match(txtPassword.Text).Success == false)
                {
                    tsMessage.Text = "密码长度不正确";
                }
                else
                {
                    tsMessage.Text = "密码规则验证正确，请稍后！";
                }
                /////判断 分流 学生 教师 管理员的访问客户端
                //学生端
                //if (combGroup.SelectedIndex == 0)
                if(rbStu.Checked==true)
                {
                    sqlString = "select * from user_student where u_number=" + common.number + " and u_pass= '" + common.oldMd5Pass + "';";
                    sql.upd(sqlString);
                    if (sql.resultInfo == true)
                    {
                        tsMessage.Text = "登陆成功！稍后进入主界面";
                        Student student = new Student();
                        student.Show();
                        this.Hide();
                        //MessageBox.Show(number);
                    }
                    else
                    {
                        tsMessage.Text = "学生用户名或密码错误";
                    }
                }
                //教师端
                //else if (combGroup.SelectedIndex == 1)
                else if(rbTea.Checked==true)
                {
                    sqlString = "select * from user_teacher where tid=" + txtNum.Text + " and t_password= '" + common.oldMd5Pass + "';";
                    sql.upd(sqlString);
                    if (sql.resultInfo == true)
                    {
                        tsMessage.Text = "登陆成功！稍后进入主界面";
                        if (common.password == "123456")
                        {
                            TeacherX teacherX = new TeacherX();
                            teacherX.Show();
                            this.Hide();
                        }
                        else
                        {
                            Teacher teacher = new Teacher();
                            teacher.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        tsMessage.Text = "教师id或密码错误";
                    }
                }
                //管理员端
                //else if (combGroup.SelectedIndex == 2)
                else if(rbAdmin.Checked==true)
                {
                    sqlString = "select * from user_admin where aid=" + txtNum.Text + " and a_password= '" + common.oldMd5Pass + "';";
                    sql.upd(sqlString);
                    if (sql.resultInfo == true)
                    {
                        tsMessage.Text = "登陆成功！稍后进入主界面";
                        if (common.password == "123456")
                        {
                            AdminX adminX = new AdminX();
                            adminX.Show();
                            this.Hide();
                        }
                        else
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        tsMessage.Text = "管理员id或密码错误";
                    }
                }
            }
            catch (Exception)
            {
                
                tsMessage.Text="发生错误，请检查输入的准确性！";
            }
        }
        //窗体图片轮播
        public int pictureIndex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureIndex = pictureIndex + 1;
            if (pictureIndex >= 3)
                pictureIndex = -1;
            if (pictureIndex == 0)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\image\bg1.png");
            }
            if (pictureIndex == 1)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\image\bg2.png");
            }
            if (pictureIndex == 2)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\image\bg3.png");
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void linkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutUS abs = new AboutUS();
            abs.Show();
        }
    }
}
