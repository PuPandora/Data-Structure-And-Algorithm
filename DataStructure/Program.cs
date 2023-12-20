using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pandora.LinkedList<int> linkedList = new Pandora.LinkedList<int>();

            // 추가 테스트
            Console.WriteLine("=== AddFirst 테스트 ===");
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.Print();
            Console.WriteLine();

            // 추가 테스트 2
            Console.WriteLine("=== AddLast 테스트 ===");
            linkedList.AddLast(11);
            linkedList.AddLast(12);
            linkedList.AddLast(13);
            linkedList.AddLast(14);
            linkedList.AddLast(15);
            linkedList.Print();
            Console.WriteLine();

            // 탐색 테스트
            Console.WriteLine("=== Find 테스트 ===");
            Console.WriteLine($"linkedList.Find(4).data : {linkedList.Find(4).data}");
            Console.WriteLine($"linkedList.Find(20) : {linkedList.Find(20)}");
            Console.WriteLine();

            // 제거 테스트
            Console.WriteLine("=== RemoveFirst 테스트 ===");
            Console.WriteLine("RemoveFirst * 3");
            for (int i = 0; i < 3; i++)
            {
                linkedList.RemoveFirst();
            }
            linkedList.Print();
            Console.WriteLine();

            // 제거 테스트 2
            Console.WriteLine("=== RemoveLast 테스트 ===");
            Console.WriteLine("RemoveLast * 3");
            for (int i = 0; i < 3; i++)
            {
                linkedList.RemoveLast();
            }
            linkedList.Print();

            // 제거 테스트 3
            Console.WriteLine("=== Clear 테스트 ===");
            linkedList.Clear();
            linkedList.Print();
            Console.WriteLine();
        }
    }
}
