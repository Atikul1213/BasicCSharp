using Microsoft.Data.SqlClient;

namespace SQLConnectionADO
{
    public class SqlDataReaderDemo
    {
        public void SqlReader()
        {
            string cs = "Data Source = BS-01344; Initial Catalog = AspnetB11; Integrated Security = true";
            SqlConnection con = null;
            using (con = new SqlConnection(cs))
            {
                con.Open();
                string query = "select* from Course";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr1 = cmd.ExecuteReader();

                // Another way
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("Id " + dr["id"] + " Name: " + dr["name"] + " Fee: " + dr["fee"]);
                        Console.WriteLine("Id " + dr[0] + " Name: " + dr[1] + " Fee: " + dr[2]);
                    }
                }

                con.Close();
            }

        }
    }
}
