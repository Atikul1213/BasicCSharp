namespace SwitchExpression
{
    public class MyClass
    {
        public static string OldSwitch(string flavour)
        {
            switch (flavour)
            {
                case "vanilla":
                    return "Vanilla";
                case "chocolate":
                    return "Chocolate";
                case "strawberry":
                    return "Strawberry";
                default:
                    return "Unknown flavour";
            }
        }

        public static string NewSwitch(string flavour)
        {
            return flavour switch
            {
                "vanilla" => "Vanilla",
                "chocolate" => "Chocolate",
                "strawberry" => "Strawberry",
                _ => "Unknown flavour"
            };
        }

        public static string GetDays(Days day)
        {
            return day switch
            {
                Days.Saturday => "This is Saturday",
                Days.Sunday => "This is Sunday",
                Days.Monday => "This is Monday",
                Days.Tuesday => "This is Tuesday",
                Days.Wednesday => "This is Wednesday",
                Days.Thursday => "This is Thursday",
                Days.Friday => "This is Friday",
                _ => "Unknown day"
            };
        }

    }
}
