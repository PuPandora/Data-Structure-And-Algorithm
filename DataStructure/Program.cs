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
            Pandora.List<int> listB = new Pandora.List<int>();

            // 리스트 추가, 용량 테스트
            Console.WriteLine("=== 리스트 추가, 용량 테스트 ===");
            for (int i = 0; i < 25;  i++)
            {
                listB.Add(i);
                Console.WriteLine($"List[{i}] : {listB[i]}");
                Console.WriteLine($"List Capacity : {listB.Capacity}");
                Console.WriteLine();
            }

            // 리스트 요소 제거 테스트
            Console.WriteLine("\n=== 리스트 요소 제거 테스트 ===");
            Console.WriteLine("Remove(5)");
            listB.Remove(5);
            foreach (var item in listB)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("RemoveAt(1)");
            listB.RemoveAt(1);
            foreach (var item in listB)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            // 리스트 탐색 테스트
            Console.WriteLine("\n=== 리스트 요소 탐색 테스트 ===");
            Console.WriteLine($"Find(4) : {listB.Find((a) => a == 4)}");
            Console.WriteLine($"Find(5) : {listB.Find((a) => a == 5)}");

            Console.WriteLine($"FindAll((a) => a <= 6) (해당 리스트의 6이하 요소들만 찾기");
            var tmpList = listB.FindAll((a) => a <= 6);
            for (int i = 0; i < tmpList.count; i++)
            {
                Console.Write($"{tmpList[i]}, ");
            }
        }
    }
}
