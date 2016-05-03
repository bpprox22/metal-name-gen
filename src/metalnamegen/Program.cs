using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metalnamegen
{
    class Program
    {
        static int Main(string[] args)
        {
            Brutal objHeadbang = new Brutal();

            if (args.Length != 1)
            {
                System.Console.WriteLine("You must run this script with an argument");
                System.Console.WriteLine("Enter a word count (1, 2, or 3)");
                System.Console.WriteLine("EX: C:\\> metalnamegen 3");
                Console.ReadLine();
                return 1;
            }

            long wordCount = Int64.Parse(args[0]);

            if (wordCount < 1 || wordCount > 3)
            {
                System.Console.WriteLine("What are you doing? I said 1, 2, or 3!");
                Console.WriteLine("You broke it. It's crippled now -- good job.");
                Console.ReadLine();
                return 1;
            }

            Console.WriteLine(objHeadbang.generateBrutalName(wordCount));
            Console.ReadLine();
            return 1;
        }
    }
}
