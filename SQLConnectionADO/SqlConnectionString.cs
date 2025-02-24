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

                    string countQuery = "select count(*) from Courses1";
                    using (SqlCommand cmd8 = new SqlCommand(countQuery, con))
                    {
                        int count = (int)cmd8.ExecuteScalar();
                        Console.WriteLine("Total count: " + count);
                    }



                    // Store procedure read from db
                    string query1 = "spGetCourseInfo";  // Give Stored procedure name
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr1 = cmd1.ExecuteReader();


                    int courseId = 1;
                    string query10 = "GetCourseById";
                    SqlCommand cmd10 = new SqlCommand(query10, con);
                    cmd10.CommandType = CommandType.StoredProcedure;
                    cmd10.Parameters.Add(new SqlParameter("@Id", courseId));

                    /* 
                     CREATE PROCEDURE CreateProduct
                        @ProductName VARCHAR(255),
                        @Price DECIMAL(10, 2),
                        @Quantity INT,
                        @NewProductId INT OUTPUT
                    AS
                    BEGIN
                        INSERT INTO Product (ProductName, Price, Quantity)
                        VALUES (@ProductName, @Price, @Quantity);
    
                        SET @NewProductId = SCOPE_IDENTITY();
                    END
                     */

                    String productName = "NewProduct";
                    decimal price = 99.99M;
                    int quantity = 12;
                    var query11 = "CreateProduct";

                    SqlCommand cmd11 = new SqlCommand(query11, con);
                    cmd11.CommandType = CommandType.StoredProcedure;
                    cmd11.Parameters.AddWithValue("@ProductName", productName);
                    cmd11.Parameters.AddWithValue("@Price", price);
                    cmd11.Parameters.AddWithValue("@Quantity", quantity);

                    SqlParameter newProdcutIdParam = new SqlParameter("@NewProductId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd11.Parameters.Add(newProdcutIdParam);

                    cmd11.ExecuteNonQuery();
                    int newProductId = (int)newProdcutIdParam.Value;



                    // Insert Into the database
                    var id = new Guid();
                    var name = "Quran";
                    var fee = 23.3;
                    string query3 = "insert into Courses1 values(@id, @name,@fee)";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@id", id);
                    cmd3.Parameters.AddWithValue("@name", name);
                    cmd3.Parameters.AddWithValue("@fee", fee);
                    var insertRowCount = cmd3.ExecuteNonQuery();
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



                    // Get Specific record
                    string query6 = "select* from Course1 where id = '1'";
                    SqlCommand cmd6 = new SqlCommand(query6, con);
                    SqlDataReader dr6 = cmd6.ExecuteReader();
                    while (dr6.Read())
                    {
                        Console.WriteLine("Id: " + dr["Id"] + " Name: " + dr["Name"] + "Fee: " + dr["Fee"]);
                    }


                    // Step 1: Start a SQL transaction.
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Step 2: Create and Execute a SqlCommand
                            string cmdText = @"INSERT INTO Employee (FirstName, LastName, Email, Position, Salary) VALUES (@FirstName, @LastName, @Email, @Position, @Salary)";
                            using (SqlCommand command = new SqlCommand(cmdText, con, transaction))
                            {
                                // Add parameters to prevent SQL injection
                                command.Parameters.AddWithValue("@FirstName", "Rakesh");
                                command.Parameters.AddWithValue("@LastName", "Sharma");
                                command.Parameters.AddWithValue("@Email", "Rakesh@Example.com");
                                command.Parameters.AddWithValue("@Position", "DBA");
                                command.Parameters.AddWithValue("@Salary", 10000);
                                // Execute the command
                                int result = command.ExecuteNonQuery();
                                Console.WriteLine("Rows affected: " + result);
                                // Step 3: Commit the Transaction
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An exception occurred. Transaction rolled back.");
                            Console.WriteLine(ex.Message);
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                        }

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
