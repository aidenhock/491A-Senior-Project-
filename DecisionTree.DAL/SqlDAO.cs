using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DecisionTree.DAL
{
    public class SqlDAO : ISqlDAO
    {
        public Response ExecuteSql(string sql)
        {
            string connectString = "";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.ExecuteNonQuery();
            }
                
            return Response;
        }
    }
}
