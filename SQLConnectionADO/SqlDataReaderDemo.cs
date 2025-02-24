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
                    Console.WriteLine("Fields count: " + dr.FieldCount);
                    Console.WriteLine("Has row: " + dr.HasRows);
                    Console.WriteLine("Is Closed: " + dr.IsClosed);

                    while (dr.Read())
                    {
                        Console.WriteLine("Id " + dr["id"] + " Name: " + dr["name"] + " Fee: " + dr["fee"]);
                        Console.WriteLine("Id " + dr[0] + " Name: " + dr[1] + " Fee: " + dr[2]);

                        var id = (int)dr["id"];
                        var name = dr["name"].ToString();
                        var fee = (decimal)dr["fee"];
                    }


                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                string dataType = dr.GetDataTypeName(i);
                                string columnName = dr.GetName(i);

                                object value = dr.GetValue(i);

                            }
                        }

                        dr.Close();

                    }

                }

                con.Close();
            }

        }
    }
}
