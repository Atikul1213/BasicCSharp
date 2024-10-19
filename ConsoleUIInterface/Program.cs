using DemoLibraryInterface;

namespace ConsoleUIInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var prd in cart)
            {
                if (prd is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} your have {digital.TotalDownloadLeft} download");
                }

                prd.ShipItem(customer);
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel()
            {
                FirstName = "Atikul ",
                LastName = "Islam",
                Email = "atikuldpi@gmail.com",
                City = "Dinajpur",
                PhoneNumber = "01722248512"

            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel() { Title = "Desktop" });
            output.Add(new PhysicalProductModel() { Title = "Laptop" });

            output.Add(new DigitalProductModel() { Title = " Lesson souce code" });

            output.Add(new CourseProductModel() { Title = ".Net coure start tot finish" });
            return output;
        }

    }
}
