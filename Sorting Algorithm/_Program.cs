using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Array
{
    private static Random random = new Random();

    public static void SetArraySize(out int[] array)
    {
        Console.Write("생성할 배열 크기를 입력해주세요.\n >> ");
        int.TryParse(Console.ReadLine(), out int inputSize);

        array = new int[inputSize];
    }

    public static void SetArraySize(int[] array, int size)
    {
        array = new int[size];
    }

    public static void PrintArrayLength(int[] array)
    {
        Console.WriteLine("intArr의 크기 : " + array.Length);
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Array[{i}] : {array[i]}");
        }
    }

    public static void MakeRandomArray(int[] array, int min, int max)
    {
        Console.WriteLine("\n===== 랜덤 배열 생성 =====\n");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
    }

    public static void MakeRandomArray(int[] array, int max)
    {
        MakeRandomArray(array, 0, max);
    }

    public static void MakeSortedArray(int[] array)
    {
        Console.WriteLine("\n===== 정렬 배열 생성 =====\n");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
    }
}

internal class _Program
{
    static int[] intRandArr;
    static int[] intSortedArr;

    static void Main(string[] args)
    {
        // 1. 배열 크기 선택
        // 2. 정렬 알고리즘 선택 (정렬 전 랜덤으로 섞음)
        // 3. 프로그램 종료
        bool programRun = true;
        while (programRun)
        {
            Console.Clear();
            Console.WriteLine("- 정렬 알고리즘 프로그램 -\n");
            Console.WriteLine("1. 배열 크기 설정");
            Console.WriteLine("2. 정렬 알고리즘");
            Console.WriteLine("3. 프로그램 종료");

            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Array.SetArraySize(out intRandArr);
                    Console.Clear();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    SelectSortAlgorithm();
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("\n프로그램을 종료합니다...\n\n");
                    programRun = false;
                    break;

                default:
                    break;
            }
        }
    }

    static void SelectSortAlgorithm()
    {
        bool isRun = true;
        bool isExit = false;
        bool isDefault = false;

        while (isRun)
        {
            Array.MakeRandomArray(intRandArr, 10);

            Console.WriteLine("1. 선택 정렬");
            Console.WriteLine("2. 버블 정렬");
            //Console.WriteLine("3. 삽입 정렬");
            Console.WriteLine("3. 나가기");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Array.PrintArray(intRandArr);
                    Sort.SelectionSort(intRandArr);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Array.PrintArray(intRandArr);
                    Sort.BubbleSort(intRandArr);
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    isRun = false;
                    isExit = true;
                    break;

                default:
                    Console.Clear();
                    isDefault = true;
                    break;
            }
            if (!isExit && !isDefault)
                Array.PrintArray(intRandArr);
        }
    }
}
