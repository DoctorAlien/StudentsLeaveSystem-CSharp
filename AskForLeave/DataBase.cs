using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AskForLeave
{
    class DataBase
    {
        public string conString = ConfigurationManager.ConnectionStrings["afl"].ConnectionString;
        public SqlConnection conn = null;
        public SqlCommand comm = null;
        DataSet ds = null;
        SqlDataAdapter sda = null;

        /// <summary>
        /// 链接数据库
        /// </summary>
        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(conString);
            }
            else if (conn.State == ConnectionState.Open)
            {
                return;
            }
            conn.Open();
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void CloseConnection()
        {
            conn.Dispose();
            conn.Close();
            conn = null;
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public DataSet GetDataSet(String sqlString)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            CloseConnection();
            return ds;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sqlString"></param>
        public void InsertData(string sqlString)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        public SqlDataAdapter UpdateData(string sqlString)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            ds = new DataSet();
            sda = new SqlDataAdapter(comm);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            return sda;
        }
        /// <summary>
        /// 判断是否存在数据
        /// </summary>
        public bool resultInfo;
        public bool upd(string sqlString)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            SqlDataReader sdr = comm.ExecuteReader();
            try 
            {
                if (sdr.Read())
                {
                    return resultInfo = true;
                }
                else
                {
                    return resultInfo = false;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
