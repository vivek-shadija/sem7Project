using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Software
{
    class Connection
    {
        SqlConnection con;
        String conStr = @"Data Source=LAPTOP-PM214RD4\SQLEXPRESS;Initial Catalog=MSTdb;Integrated Security=True";
        public Connection()
        {
            con = new SqlConnection(conStr);
        }
        public bool conOpen()
        {
            if(con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch(Exception exx)
                {
                    return false;
                }
            }
            return false;
        }
        public bool conClose()
        {
            if (con.State != ConnectionState.Closed)
            {
                try
                {
                    con.Close();
                    return true;
                }
                catch (Exception exx)
                {
                    return false;
                }
            }
            return false;
        }
        public bool performDML(string q) //used for insert, update and delete 
        {
            SqlCommand cmd = new SqlCommand(q, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e);
                return false;
            }
        }
        public DataTable fetchData(string q) //used for select
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(q, conStr);
            da.Fill(dt);
            return dt;
        }
    }
}
