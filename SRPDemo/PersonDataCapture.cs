namespace SRPDemo
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();
            Console.WriteLine("Enter your first name: ");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
