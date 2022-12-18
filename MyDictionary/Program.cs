using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(54, "Sakarya");
            myDictionary.Add(52, "Ordu");
            myDictionary.Add(45, "Manisa");

            Console.WriteLine(myDictionary.Count);
            Console.ReadLine();
        }
    }
}
