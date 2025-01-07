using System;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
namespace NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Leccion 22-Excepciones\Example.txt", reply);
            Console.ReadLine();
        }
    }
}
