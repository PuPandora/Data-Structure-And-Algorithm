using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public static class Sort
    {
        public static void BubbleSort(int[] array)
        {
            // 1. (배열의 길이-1) * (배열의 길이-1) 만큼 비교한다.
            // 2. n번째 요소를 n+1번째 요소와 비교
            // 2-1. n번째 요소가 크다면 위치 교환
            // 3. 첫 반복이 끝났다면 가장 큰 숫자가 가장 뒤에 위치 됨
            // 4. 반복 횟수가 늘어나면, 가장 뒤에 정렬되는 요소 개수가 동일하게 증가한다

            Console.WriteLine("\n===== 버블 정렬 =====\n");

            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

                        swapCount++;
                    }
                    comparisonCount++;
                }
            }
            PrintOperationCount(comparisonCount, swapCount);
        }

        public static void SelectionSort(int[] array)
        {
            // 1. 배열의 n번째 요소를 minNumberIndex에 저장한다.
            // 2. 배열의 n+1 인덱스 요소부터 비교를 시작하며,
            // 배열[minNumberIndex] 요소와 다음 인덱스 요소 값과 비교한다.
            // 2-1. 만약 다음 요소가 더 작다면, minNumberIndex를 다음 인덱스로 갱신한다.
            // 3. 전부 순회한 뒤, 배열[n] 요소와 배열[minNumberIndex] 요소를 서로 교환한다.
            // 4. n+1 하고 2~4 과정을 배열의 길이만큼 반복한다.

            Console.WriteLine("\n===== 선택 정렬 =====\n");

            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int minNumberIndex = i;
                int temp = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    // Comparison
                    if (array[j] < array[minNumberIndex])
                    {
                        minNumberIndex = j;
                    }
                    comparisonCount++;
                }

                // Swap
                if (i != minNumberIndex)
                {
                    temp = array[i];
                    array[i] = array[minNumberIndex];
                    array[minNumberIndex] = temp;
                }

                swapCount++;
            }
            PrintOperationCount(comparisonCount, swapCount);
        }

        public static void InsertionSort(int[] array)
        {
            // 1. 배열의 길이만큼 반복한다
            // 2. 현재 인덱스 요소(i)와 현재 진행 중인 인덱스-1 요소(j)를 비교한다.
            // 3. 만약 i가 작다면 서로 교환한다.
            // 3-1. i-1 요소와 j-1 요소를 비교하고, i가 작다면 교환한다.
            // 4. 만약 i가 작지 않다면, 다음 요소 검사로 넘어간다.

            Console.WriteLine("\n===== 삽입 정렬 =====\n");

            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int curIndex = i;
                for (int j = i-1; j >= 0; j--)
                {
                    // Comparison
                    comparisonCount++;

                    if (array[curIndex] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[curIndex];
                        array[curIndex] = temp;

                        curIndex--;
                        swapCount++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            PrintOperationCount(comparisonCount, swapCount);
        }

        public static void MergeSort(int[] array)
        {

        }

        private static void PrintOperationCount(int comparisonCount, int swapCount)
        {
            Console.WriteLine($"비교 횟수 : {comparisonCount}\n교환 횟수 : {swapCount}\n");
            Console.WriteLine("===== ===== ===== =====\n");
        }
    }
}
