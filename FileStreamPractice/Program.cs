using System.Text;

public class StreamPractice
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\MyFile.txt";

        FileStream fileStream = new FileStream(filePath, FileMode.Create);
        fileStream.Close();
        Console.WriteLine("File has been created and the path");

        FileStream filestream1 = new FileStream(filePath, FileMode.Append);
        byte[] bytedata = Encoding.Default.GetBytes("C# is an object oriented programming language");

        filestream1.Write(bytedata, 0, bytedata.Length);
        filestream1.Close();

        string data;
        FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        using (StreamReader streamReader = new StreamReader(fileStream2))
        {
            data = streamReader.ReadToEnd();
        }






    }
}