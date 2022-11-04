using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>()
            {
                "C", "C++", "C#", "Java", "Ruby"
            };

            HashSet<string> myhash2 = new HashSet<string>()
            {
                "PHP", "C++", "Perl", "Java"
            };

            myhash2.IntersectWith(myhash1);
            Console.WriteLine("myhash1\n");
            foreach (var elem in myhash1)
                Console.Write(elem + " ");

            Console.WriteLine("\nmyhash2\n");
            foreach (var elem in myhash2)
                Console.Write(elem + " ");
        }
    }
}
