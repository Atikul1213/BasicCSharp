namespace AbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqliteDataAccess da = new SqliteDataAccess();
            da.LoadConnectionString("demo");

            DataAccess da1 = new SqlDataAccess();

            da1.LoadData("select * from table");


            List<DataAccess> databases = new List<DataAccess>();
            {
                new SqlDataAccess();
                new SqliteDataAccess();
            }

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");

            }

            Console.WriteLine("Hello World!");
        }
    }
}
