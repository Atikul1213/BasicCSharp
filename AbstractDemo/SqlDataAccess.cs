namespace AbstractDemo
{
    public class SqlDataAccess : DataAccess
    {


        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft sql data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data tot microsoft sql server");
        }
    }
}
