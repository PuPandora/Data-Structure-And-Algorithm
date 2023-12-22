using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandora.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);

            }

            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
                Console.WriteLine($"Stack Capacity : {stack.Capacity}");
                Console.WriteLine($"Stack Count : {stack.Count}");
            }
        }
    }
}
