using System;

namespace csharpExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Bill", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);
        }
    }
}
