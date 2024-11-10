namespace SRPDemo
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (String.IsNullOrEmpty(person.FirstName))
                return false;

            if (String.IsNullOrEmpty(person.LastName))
                return false;

            return true;
        }
    }
}
