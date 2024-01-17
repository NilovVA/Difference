using System;
using System.Collections.Generic;
using System.Linq;
namespace difference
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] names1 = System.IO.File.ReadAllLines(@"../../../../name1.txt");
            string[] names2 = System.IO.File.ReadAllLines(@"../../../../name2.txt");
            IEnumerable<string> differenceQuerry =
                names1.Except(names2);
            Console.WriteLine("Список строк который есть в файле 1 но нет в файле 2");
            foreach (string s in differenceQuerry)
                Console.WriteLine(s);
            
        }
    }
}
