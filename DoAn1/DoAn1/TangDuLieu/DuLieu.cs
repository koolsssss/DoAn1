using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn1.TangDuLieu
{
    class DuLieu
    {
        string Constr = @"Data Source=DESKTOP-EC7AJLL\SQLEXPRESS;Initial Catalog=QuanLiSieuThi;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comn = null;
        SqlDataAdapter da = null;
        public DuLieu()
        {
            conn = new SqlConnection(Constr);
            comn = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
          conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;
            da = new SqlDataAdapter(comn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable ExecuteDataTable(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;
            da = new SqlDataAdapter(comn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public object Executequery(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;

            object dt = comn.ExecuteScalar();
            return dt;
        }

        //public float Executequery1(string strSQL, CommandType ct)
        //{
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //    conn.Open();
        //    comn.CommandText = strSQL;
        //    comn.CommandType = ct;

        //    float dt = (float)comn.ExecuteScalar();
        //    return dt;
        //}
        public bool MyExcuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comn.CommandText = strSQL;
            comn.CommandType = ct;
            try
            {
                comn.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
