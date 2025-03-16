namespace Tuples
{
    public class TupleExample
    {
        // Old way of returning multiple values
        public Tuple<int, double> Calculate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }

            Tuple<int, double> tuple = Tuple.Create(count, sum);

            return tuple;
        }

        // New way of returning multiple values
        public (int, double) Calculate1(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }

            return (count, sum);
        }


        public (string, double, string, string) GetEmployeeDetails(long EmployeeId)
        {
            string name = "Atikul Islam";
            double salary = 100000.00;
            string company = "Brain Station 23";
            string designation = "Software Engineer";

            return (name, salary, company, designation);
        }
    }
}
