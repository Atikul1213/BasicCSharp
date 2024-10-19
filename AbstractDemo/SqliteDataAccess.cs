namespace AbstractDemo
{
    public class SqliteDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += "from sqlite";
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading   sql  lite data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data tot   sql lite server");
        }
    }
}
