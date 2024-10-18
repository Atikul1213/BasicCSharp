namespace RandomNumberDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Random: " + random.Next());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Randdom: " + random.Next(5, 11));
                Console.WriteLine("Random double: " + random.NextDouble());
                SimpleMethod(random);

            }

            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel{FirstName = "John"},
                new PersonModel{FirstName = "Steve"},
                new PersonModel{FirstName = "Bill"}
            };

            var sortedPeople = people.OrderBy(x => random.Next());
            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
        }


        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}




