using System.Text;
namespace CSharp
{
    public class StringBuilderExample
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('-', 6);
            sb.Append(" Here is a titile! ");
            sb.Append('-', 6);
            Console.WriteLine("sb: " + sb);

            sb.AppendLine();
            sb.Append("And here is a paragraph");

            Console.WriteLine("sb: " + sb);

            sb.Replace("And here is a paragraph", "Whops!");
            Console.WriteLine("sb: " + sb);

            sb.Remove(0, 30);
            sb.Insert(0, 30);
            Console.WriteLine("now sb: " + sb);
            sb.Insert(0, "My name is Atikul");
            Console.WriteLine("sb: " + sb);
        }
    }
}