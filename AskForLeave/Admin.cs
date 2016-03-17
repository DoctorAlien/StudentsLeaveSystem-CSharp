//============================================
//Project Name:AskForLeave
//Form Name:Admin/管理界面
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
using System.Data.SqlClient;

namespace AskForLeave
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        DataSet teaComb=null;
        private void Admin_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //加载数据
            btnLoadStu_Click(null, null);
            btnLoadTea_Click(null, null);
            //默认combTea加载数据
            sqlString = "select tid,t_name from user_teacher";
            teaComb = sql.GetDataSet(sqlString);
            combTea.DataSource = teaComb.Tables[0];
            combTea.DisplayMember = "t_name";
            combTea.ValueMember = "tid";
        }

        public string sqlString = "";
        DataSet dsStu = null;
        DataSet dsTea = null;
        DataBase sql = new DataBase();
        /// <summary>
        /// 加载学生表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadStu_Click(object sender, EventArgs e)
        {
            //sqlString = " select uid,u_number,u_name,u_class,u_pass,ut.t_name from user_student as us,user_teacher as ut where us.tid=ut.tid";
            sqlString = "select * from user_student";
            dsStu = sql.GetDataSet(sqlString);
            dgvStu.DataSource = dsStu.Tables[0];
            dgvStu.Columns[0].HeaderText = "学生人数";
            dgvStu.Columns[1].HeaderText = "学号";
            dgvStu.Columns[2].HeaderText = "学生姓名";
            dgvStu.Columns[3].HeaderText = "学生班级";
            dgvStu.Columns[4].HeaderText = "学生密码";
            dgvStu.Columns[5].HeaderText = "辅导员编号";
        }
        /// <summary>
        /// 加载教师表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadTea_Click(object sender, EventArgs e)
        {
            sqlString = "select * from user_teacher";
            dsTea = sql.GetDataSet(sqlString);
            dgvTea.DataSource = dsTea.Tables[0];
            dgvTea.Columns[0].HeaderText = "教师人数";
            dgvTea.Columns[1].HeaderText = "教师姓名";
            dgvTea.Columns[2].HeaderText = "教师密码";
            dgvTea.Columns[3].HeaderText = "教师权限";
        }
        /// <summary>
        /// 更新学生表
        /// </summary>
        public SqlDataAdapter sda = null;
        private void btnReloadStu_Click(object sender, EventArgs e)
        {
            tsMessage.Text = "";
            sda = sql.UpdateData("select * from user_student");
            try
            {
                sda.Update(dsStu.Tables[0].GetChanges());
                dsStu.Tables[0].AcceptChanges();
                tsMessage.Text = "学生信息更新成功！";
            }
            catch (Exception)
            {
                tsMessage.Text = "学生信息更新出错，请重启！";
            }
        }
        /// <summary>
        /// 更新教师表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReloadTea_Click(object sender, EventArgs e)
        {
            tsMessage.Text = "";
            sda = sql.UpdateData("select * from user_teacher");
            try
            {
                sda.Update(dsTea.Tables[0].GetChanges());
                dsTea.Tables[0].AcceptChanges();
                tsMessage.Text = "教师信息更新成功！";
            }
            catch (Exception)
            {
                tsMessage.Text = "教师信息更新出错，请重启！";
            }
        }
        /// <summary>
        /// 教师信息删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTea_Click(object sender, EventArgs e)
        {
            try
            {
                dsTea.Tables[0].Rows[dgvTea.CurrentRow.Index].Delete();
                SqlDataAdapter sda = sql.UpdateData("select * from user_teacher");
                sda.Update(dsTea.Tables[0].GetChanges());
                dsTea.Tables[0].AcceptChanges();
                tsMessage.Text = "教师信息删除成功！";
            }
            catch (Exception)
            {

                tsMessage.Text = "出错，请检查后重新输入！";
            }
        }
        /// <summary>
        /// 学生信息删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            try
            {
                dsStu.Tables[0].Rows[dgvStu.CurrentRow.Index].Delete();
                SqlDataAdapter sda = sql.UpdateData("select * from user_student");
                sda.Update(dsStu.Tables[0].GetChanges());
                dsStu.Tables[0].AcceptChanges();
                tsMessage.Text = "学生信息删除成功！";
            }
            catch (Exception)
            {

                tsMessage.Text = "出错，请检查后重新输入！";
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseStu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCloseTea_Click(object sender, EventArgs e)
        {
            btnCloseStu_Click(null, null);
        }
        /// <summary>
        /// 学生信息插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateStu_Click(object sender, EventArgs e)
        {
            try
            {
                string stuNum = txtNum.Text;
                string stuName = txtName.Text;
                string stuClass = txtClass.Text;
                int stuTea = combTea.SelectedIndex + 1;
                //MessageBox.Show(stuTea.ToString());
                sqlString = "insert into user_student (u_number,u_name,u_class,tid) values(" + stuNum + ",'" + stuName + "','" + stuClass + "'," + stuTea + ")";
                sql.InsertData(sqlString);
                tsMessage.Text = "学生信息插入成功！";
                btnLoadStu_Click(null, null);
            }
            catch (Exception)
            {
                
                tsMessage.Text = "出错，请检查后重新输入！";
            }
        }
        /// <summary>
        /// 教师信息插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTea_Click(object sender, EventArgs e)
        {
            try
            {
                string teaName = txtTeacher.Text;
                sqlString = "insert into user_teacher (t_name) values('" + teaName + "')";
                sql.InsertData(sqlString);
                tsMessage.Text = "教师信息插入成功！";
                btnLoadTea_Click(null, null);
            }
            catch (Exception)
            {
                
                tsMessage.Text = "出错，请检查后重新输入！";
            }
        }
        /// <summary>
        /// 学生插入信息重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetStu_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            combTea.SelectedIndex = 0;
        }
        /// <summary>
        /// 教师查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLinqTea_Click(object sender, EventArgs e)
        {
            string teaName = txtLinqTea.Text;
            sqlString = "select * from user_teacher where t_name like '%" + teaName + "%'";
            dsTea = sql.GetDataSet(sqlString);
            dgvTea.DataSource = dsTea.Tables[0];
        }

        private void btnLinqStu_Click(object sender, EventArgs e)
        {
            string stuName = txtLinqStu.Text;
            sqlString = "select uid,u_number,u_name,u_class,u_pass,ut.t_name from user_student as us,user_teacher as ut where us.tid=ut.tid and u_name like '%" + stuName + "%'";
            dsStu = sql.GetDataSet(sqlString);
            dgvStu.DataSource = dsStu.Tables[0];
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //System.Environment.Exit(0);
        }

        private void btnCreateMD5_Click(object sender, EventArgs e)
        {
            md5Create mdc = new md5Create();
            mdc.Show();
        }
    }
}
