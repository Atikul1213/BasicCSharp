namespace SQLConnectionADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sqlConnectionString = new SqlConnectionString();
            sqlConnectionString.Connection();

            var sqlDataReaderDemo = new SqlDataReaderDemo();
            sqlDataReaderDemo.SqlReader();

            Console.ReadLine();
        }

    }
}
