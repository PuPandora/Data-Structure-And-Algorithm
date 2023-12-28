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
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 30; i++)
            {
                stack.Push(i);
                Console.WriteLine($"PUSH! Pushed item : {i}");
                Console.WriteLine($"Capacity : {stack.Capacity}");
                Console.WriteLine($"Count : {stack.Count}");
                Console.WriteLine();
            }
            foreach (var item in stack)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            int element1 = 384561;
            if (stack.Contains(element1))
            {
                Console.WriteLine($"stack 안에 {element1}이/가 있습니다.");
            }
            else
            {
                Console.WriteLine($"stack 안에 {element1}이/가 없습니다.");
            }
        }
    }
}
