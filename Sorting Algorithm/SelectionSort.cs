using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        // 1. 현재 i번째 요소의 값을 a, b로 저장한다.
        // 2. 요소 값 보다 작은게 있다면 b에 대입한다.
        // 1, 2 과정을 반복하며 쭉 배열의 모든 값을 읽는다.
        // 3. 가장 작은 값이 나온 인덱스 j를 저장한다.
        // 4. 가장 작은 값이 저장된 b를 i에 저장하고
        // 5. 첫 번째 지정한 a를 j에 저장하여 교환한다.

        int selection = 0;
        int original = 0;
        int targetIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            selection = array[i]; original = array[i];

            for (int j = i; j < array.Length; j++)
            {
                // 현재 진행 중인 단계의 요소가
                // 선택 중인 것 보다 작다면
                if (array[j] < selection)
                {
                    selection = array[j];
                    targetIndex = j;
                }
            }
            // 최소값과 선택한 값 위치 교환
            array[i] = selection;
            array[targetIndex] = original;
        }
    }
}
