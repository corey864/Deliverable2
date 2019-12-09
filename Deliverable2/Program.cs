using System;
using System.Text;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your message?");
            Console.ReadLine();

            String s = "corey";
            StringBuilder sb = new StringBuilder();
            for (char c; ; s.ToCharArray())
            {
            
                sb.Append((char)('c' - 'a' + 1));
            }
        }
    }
}
