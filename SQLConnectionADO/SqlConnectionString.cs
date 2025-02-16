using Microsoft.Data.SqlClient;
using System.Data;

namespace SQLConnectionADO
{
    public class SqlConnectionString
    {
        public void Connection()
        {
            string cs = "Data Source = BS-01344; Initial Catalog = AspnetB11; Integrated Security = true";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = "select * from Courses";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("Id: " + dr["Id"] + " Name: " + dr["Name"] + "Fee: " + dr["Fee"]);
                    }

                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection has been created successfully.");
                    }

                    cmd.CommandText = query;
                    cmd.Connection = con;


                    // Store procedure read from db
                    string query1 = "spGetCourseInfo";  // Give Stored procedure name
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr1 = cmd.ExecuteReader();


                    // Insert Into the database
                    var id = new Guid();
                    var name = "Quran";
                    var fee = 23.3;
                    string query3 = "insert into Courses1 values(@id, @name,@fee)";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@id", id);
                    cmd3.Parameters.AddWithValue("@name", name);
                    cmd3.Parameters.AddWithValue("@fee", fee);
                    var insertRowCount = cmd.ExecuteNonQuery();
                    if (insertRowCount > 0)
                    {
                        Console.WriteLine("Data has been inserted successfully " + insertRowCount);
                    }
                    else
                    {
                        Console.WriteLine("Data Insertion failed...");
                    }



                    // Update Query
                    string query4 = "update Course1  set name = @name, fee = @fee where id = @id";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    cmd4.Parameters.AddWithValue("@id", id);
                    cmd4.Parameters.AddWithValue("@name", name);
                    cmd4.Parameters.AddWithValue("@fee", fee);
                    var rowInserted = cmd4.ExecuteNonQuery();
                    if (rowInserted > 0)
                    {
                        Console.WriteLine("Data has been updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data updated failed.");
                    }



                    // Delete query
                    string query5 = "delete from Course1 where id = @id";
                    SqlCommand cmd5 = new SqlCommand(query5, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    var deleteRowCount = cmd5.ExecuteNonQuery();

                    if (deleteRowCount > 0)
                    {
                        Console.WriteLine("Data has been delete successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data Deletation failed");
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
