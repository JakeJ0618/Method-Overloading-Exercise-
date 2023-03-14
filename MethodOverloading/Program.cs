using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace MethodOverloading
{
    public class Program
    {
        public static void Main()
        {
            var answer = Methods.Add(6, 8);
            Console.WriteLine(answer);
        }
        
        
    }
}
