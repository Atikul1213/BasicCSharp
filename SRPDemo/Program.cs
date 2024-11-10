using SRPDemo;

public class Program
{
    static void Main(string[] args)
    {
        StandardMessages.WelcomeMessage();

        Person user = new Person();
        user = PersonDataCapture.Capture();

        var isValid = PersonValidator.Validate(user);

        if (!isValid)
            StandardMessages.EndApplication();

        AccountGenerator.CreateAccount(user);
        StandardMessages.EndApplication();
    }
}