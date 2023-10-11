using Microsoft.Data.SqlClient;

namespace DecisionTree.DataAccess
{
    public class Data
    {
        public static void InsertData(string DataName, string DataInfo)
        {
            //Initialize DataId
            int DataId = 0;
            //Create new SqlConnection
            SqlConnection con = new SqlConnection(@"Server=LAPTOP-2D76P4BO; Database=DataAccess; User Id=kickingdude8; Password=kkksammy2; TrustServerCertificate =True;");
            con.Open();
            //Using the SqlCommand we will get the Max DataId and assign the local DataId to that value plus 1
            using (SqlCommand getId = new SqlCommand(@"SELECT MAX(DataId) FROM data", con))
            {
                Console.WriteLine(getId);
                SqlDataReader reader = getId.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        DataId = reader.GetInt32(0) + 1;

                    }
                }
                reader.Close();
            }
            //Insert DataId, DataName, and DataInfo into our data table
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[data]([DataId], [DataName], [DataInfo]) VALUES('" + (DataId) + "', '" + DataName + "', '" + DataInfo + "')", con);
            //Executes the Query
            cmd.ExecuteNonQuery();
            //Output to show our Query went through
            Console.WriteLine("data inserted successfully");
            //Closes the Connection
            con.Close();
        }
    }



}