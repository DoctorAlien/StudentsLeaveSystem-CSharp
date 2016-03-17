//============================================
//Project Name:AskForLeave
//Form Name:Teacher/教师管理界面
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
using System.Drawing.Printing;

namespace AskForLeave
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        public string sqlString = null;
        DataBase sql = new DataBase();
        public DataSet ds = null;
        DataSet combEnable = null;
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Teacher_Load(object sender, EventArgs e)
        {
            //加载没有审核过的假条至dataGridView1
            sqlString = "select id,u_name,u_class,create_date,expiration_date,u_message,ins.status,t_message from user_student as us,leave_ticket as lt,isenable as ins  where us.uid=lt.uid and lt.enable=0 and ins.enable=lt.enable and tid="+common.number;
            ds = sql.GetDataSet(sqlString);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "假条编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生班级";
            dataGridView1.Columns[3].HeaderText = "开始时间";
            dataGridView1.Columns[4].HeaderText = "截止时间";
            dataGridView1.Columns[5].HeaderText = "假条信息";
            dataGridView1.Columns[6].HeaderText = "审核状态";
            dataGridView1.Columns[7].HeaderText = "教师回复";
            //加载combEnable的默认数据
            sqlString = "select * from isenable";
            combEnable = sql.GetDataSet(sqlString);
            combIsEnable.DataSource = combEnable.Tables[0];
            combIsEnable.DisplayMember = "status";
            combIsEnable.ValueMember = "enable";
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLeave(object sender, DataGridViewCellEventArgs e)
        {
            //将数据加载至TextBox
            common.teacher_leave_id = Convert.ToString(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            txtName.Text = Convert.ToString(dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            txtClass.Text = Convert.ToString(dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            txtStart.Text = Convert.ToString(dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            txtEnd.Text = Convert.ToString(dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value).Trim();
            txtLeave.Text = Convert.ToString(dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value).Trim();
        }
        /// <summary>
        /// 回复假条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //判断教师回复是否为空  为空返回null
            string t_message=txtMessageTea.Text;
            if (t_message == "")
            {
                t_message = "null";
            }
            sqlString = "update leave_ticket set enable=" + combIsEnable.SelectedIndex + ",t_message='" + t_message + "' where id=" + common.teacher_leave_id;
            sql.InsertData(sqlString);
            tsMessage.Text = "回复成功！";
            //清空
            txtName.Text = "";
            txtClass.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
            txtLeave.Text = "";
            combIsEnable.SelectedIndex = 0;
            txtMessageTea.Text = "";
            //dataGridView1数据加载
            Teacher_Load(null, null);
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tesClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 查看教师所属班级所有假条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLookAll_Click(object sender, EventArgs e)
        {
            sqlString = "select id,u_name,u_class,create_date,expiration_date,u_message,ins.status,t_message from user_student as us,leave_ticket as lt,isenable as ins  where us.uid=lt.uid and ins.enable=lt.enable and tid=" + common.number;
            ds = sql.GetDataSet(sqlString);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "假条编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生班级";
            dataGridView1.Columns[3].HeaderText = "开始时间";
            dataGridView1.Columns[4].HeaderText = "截止时间";
            dataGridView1.Columns[5].HeaderText = "假条信息";
            dataGridView1.Columns[6].HeaderText = "审核状态";
            dataGridView1.Columns[7].HeaderText = "教师回复";
            tsMessage.Text = "已经显示您所带班级的所有假条！";
        }
        /// <summary>
        /// 打印,打印浏览，打印分词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            //设置打印用的纸张
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 500, 500);
            //PrintPage事件，打印每一页时会触发该事件
            printDocument1.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            //初始化打印预览对话框对象
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            //将printDocument1对象赋值给打印预览对话框的Document属性
            printPreviewDialog1.Document = printDocument1;
            //打开打印预览对话框
            DialogResult result = printPreviewDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();//开始打印
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //设置打印内容及其字体，颜色和位置
            Font font = new Font("黑体", 15, FontStyle.Bold);
            SolidBrush BlcakBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(GetPrintStr(), font, BlcakBrush, 10, 10);
        }
        public string GetPrintStr()
        {
            string newLeave="";
            string leaveRN = "\r\n         ";
            if (txtLeave.Text.Length > 18)
            {
                newLeave = txtLeave.Text.Insert(18, leaveRN);
            }
            else
            {
                newLeave = txtLeave.Text;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("                  " + "请假条" + "     \r\n");
            sb.Append("--------------------------------------------\r\n");
            sb.Append("日期:" + DateTime.Now.ToShortDateString() + "         " + "假条号:" + common.teacher_leave_id + "" + "\r\n");
            sb.Append("--------------------------------------------\r\n");
            sb.Append("申 请 人:" + txtName.Text + "\r\n");
            sb.Append("\r\n");
            sb.Append("班    级:"+txtClass.Text+"\r\n");
            sb.Append("\r\n");
            sb.Append("开始时间:" + txtStart.Text + "\r\n");
            sb.Append("\r\n");
            sb.Append("结束时间:" + txtEnd.Text + "\r\n");
            sb.Append("\r\n");
            sb.Append("请假理由:" + newLeave + "\r\n");
            sb.Append("\r\n");
            sb.Append("--------------------------------------------\r\n");
            sb.Append("                  " + "特此申请" + "     \r\n");
            sb.Append("--------------------------------------------\r\n");
            return sb.ToString();
        }
    }
}
