using Microsoft.Data.SqlClient;
using System.Data;

namespace SQLConnectionADO
{
    public class SqlConnectionString
    {
        public void Connection()
        {
            string cs = "Data Source = BS-01344; Initial Catalog = Ado_db; Integrated Security = true";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection has been created successfully.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql exception: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
