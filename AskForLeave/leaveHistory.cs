//============================================
//Project Name:AskForLeave
//Form Name:leaveHistory/学生假条列表界面
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
    public partial class leaveHistory : Form
    {
        public leaveHistory()
        {
            InitializeComponent();
        }
        public string sqlString = null;
        DataBase sql = new DataBase();
        public DataSet ds = null;
        private void leaveHistory_Load(object sender, EventArgs e)
        {
            //固定宽高比，不可以拉伸
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //窗体加载已有假条数据
            sqlString = "select id,u_message,create_date,expiration_date,status,t_message from leave_ticket as lt,isenable as isn where uid="+common.uid+" and lt.enable=isn.enable";
            ds = sql.GetDataSet(sqlString);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "假条编号";
            dataGridView1.Columns[1].HeaderText = "假条详情";
            dataGridView1.Columns[2].HeaderText = "开始时间";
            dataGridView1.Columns[3].HeaderText = "截至时间";
            dataGridView1.Columns[4].HeaderText = "审核状态";
            dataGridView1.Columns[5].HeaderText = "教师回复";

        }
    }
}
