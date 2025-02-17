using Microsoft.Data.SqlClient;
using System.Data;

namespace SQLConnectionADO
{
    public class SqlDataAdapterPractice
    {

        public void DataAdapter()
        {
            string cs = "Data Source = BS-01344; Initial Catalog = AspnetB11; Integrated Security = true";
            SqlConnection con = null;

            using (con = new SqlConnection(cs))
            {
                string query = "select * from Couse1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet();
                sda.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine("Id: " + dr[0] + "  Name: " + dr[1] + " Fee: " + dr[2]);
                }
            }
        }

    }
}
