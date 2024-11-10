namespace SRPDemo
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            var fullName = $"{user.FirstName} {user.LastName} create account successfully";

            Console.WriteLine(fullName);

        }
    }
}
