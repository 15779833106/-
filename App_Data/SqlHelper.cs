using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// SqlHelper 的摘要说明
/// </summary>
public class SqlHelper
{

    //获取配置文件中 数据库连接字符串
    private static readonly string connString = ConfigurationManager.
        ConnectionStrings["shoppingCar"].ConnectionString;

    /// <summary>
    /// 执行增删改操作的方法
    /// </summary>
    /// <param name="sql">增删改的SQL语句  必填</param>
    /// <param name="commandParams">参数数组  选填</param>
    /// <returns></returns>
    public static int ExecNonQuery(string sql,
        params SqlParameter[] commandParams)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand cmd = new SqlCommand();
            PreParedCommand(sql, commandParams, conn, cmd);

            return cmd.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// 执行查询 返回第一行第一列的数据
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="commandParams"></param>
    /// <returns>第一行第一列的数据</returns>
    public static object ExecScalar(string sql,
       params SqlParameter[] commandParams)
    {
        //自动释放资源
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand cmd = new SqlCommand();
            PreParedCommand(sql, commandParams, conn, cmd);

            return cmd.ExecuteScalar();
        }
    }

    /// <summary>
    /// 查询方法  读取数据必须保存数据库连接状态
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="commandParams"></param>
    /// <returns>SqlDataReader对象</returns>
    public static SqlDataReader ExecDataReader(string sql, params SqlParameter[] commandParams)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();
        PreParedCommand(sql, commandParams, conn, cmd);

        //CommandBehavior.CloseConnection: 若dataReader对象关闭则自动关闭connection对象
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }

    /// <summary>
    /// 执行查询 断开式
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="commandParams"></param>
    /// <returns>DataSet对象</returns>
    public static DataSet ExecDataSet(string sql, params SqlParameter[] commandParams)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand cmd = new SqlCommand();
            PreParedCommand(sql, commandParams, conn, cmd);

            //创建适配器对象
            using (SqlDataAdapter dap = new SqlDataAdapter())
            {
                dap.SelectCommand = cmd;//适配器对象关联command对象
                DataSet ds = new DataSet();
                dap.Fill(ds);
                return ds;
            }
        }
    }

    /// <summary>
    /// 设置command对象属性
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="commandParams"></param>
    /// <param name="conn"></param>
    /// <param name="cmd"></param>
    private static void PreParedCommand(string sql, SqlParameter[] commandParams, SqlConnection conn, SqlCommand cmd)
    {
        //判断数据库连接对象若不是打开状态则打开
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.CommandText = sql;//设置执行的SQL语句
        cmd.Connection = conn;//关联数据库连接对象

        if (commandParams != null)
        {
            foreach (SqlParameter sp in commandParams)
            {
                cmd.Parameters.Add(sp);//遍历参数赋给command对象参数集合接收
            }
        }
    }

    public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pms)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connString);
        if (pms != null)
        {
            adapter.SelectCommand.Parameters.AddRange(pms);
        }
        adapter.Fill(dt);
        return dt;
    }
    public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
    {
        using (SqlConnection con = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}