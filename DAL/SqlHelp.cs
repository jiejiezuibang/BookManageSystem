using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// 连接数据库帮助类
    /// </summary>
    public class SqlHelp
    {
        // 连接数据库字符串
        private string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        /// <summary>
        /// 获取数据表(有参)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlpars"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql,SqlParameter[] sqlpars)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                // 打开数据库连接
                conn.Open();
                // 操作数据库
                using(SqlCommand comm = conn.CreateCommand())
                {
                    // 要执行的sql语句
                    comm.CommandText = sql;
                    // 为sql语句添加参数
                    comm.Parameters.AddRange(sqlpars);
                    // 将数据注入ds
                    using(SqlDataAdapter sda = new SqlDataAdapter(comm))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        return dt;
                    }
                }
            }
        }
        /// <summary>
        /// 获取数据表(无参)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                // 打开数据库连接
                conn.Open();
                using(SqlCommand comm = conn.CreateCommand())
                {
                    // 要执行的sql语句
                    comm.CommandText = sql;
                    using(SqlDataAdapter sda = new SqlDataAdapter(comm))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        return dt;
                    }
                }
            }
        }
        /// <summary>
        /// 操作数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlpars"></param>
        /// <returns></returns>
        public int SqlOperate(string sql,SqlParameter[] sqlpars)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                // 打开数据库连接
                conn.Open();
                using(SqlCommand comm = conn.CreateCommand())
                {
                    // 要执行的sql语句
                    comm.CommandText = sql;
                    // 追加的参数
                    comm.Parameters.AddRange(sqlpars);
                    // 返回受影响行数
                    int result = comm.ExecuteNonQuery();
                    return result;
                }
            }
        }
        /// <summary>
        /// 操作数据库事务(有参)
        /// </summary>
        /// <param name="sqls"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool UW(string[] sqls, List<SqlParameter[]> list)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                // 打开数据库连接
                conn.Open();
                // 事务开始
                using(SqlTransaction tonn = conn.BeginTransaction())
                {
                    using(SqlCommand comm = conn.CreateCommand())
                    {
                        try
                        {
                            comm.Connection = conn;
                            comm.Transaction = tonn;
                            for(int i = 0; i < sqls.Length; i++)
                            {
                                // 要还行的sql语句
                                comm.CommandText = sqls[i];
                                // 追加给sql语句的参数
                                comm.Parameters.AddRange(list[i]);
                                // 获得受影响行数
                                comm.ExecuteNonQuery();
                            }
                            // 提交事务
                            tonn.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            // 回滚事务
                            tonn.Rollback();
                            return false;
                        }
                    }
                }
            }
        }
    }
}
