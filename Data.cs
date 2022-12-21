using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace data__base
{
    class Data
    {
        SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader;

        public Data()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void Reader()
        {
            reader = cmd.ExecuteReader();

        }
        public void Query(string q)
        {
            cmd = new SqlCommand(q, con);
        }
        public int Run()
        {
            return cmd.ExecuteNonQuery();
        }
    }
}
