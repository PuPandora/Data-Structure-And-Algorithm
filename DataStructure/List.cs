using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pandora
{
    internal class List<T>
    {
        private T[] items;
        private int size = 0;

        public int count { get => size; }

        public int Capacity
        {
            get => items.Length;
            set
            {
                if (value != items.Length)
                {
                    // 1이상 설정할 경우
                    if (value > 0)
                    {
                        T[] newItems = new T[value];

                        // 이미 리스트에 요소가 있다면 복사
                        if (size > 0)
                        {
                            for (int i = 0; i < size; i++)
                            {
                                newItems[i] = items[i];
                            }
                        }
                        items = newItems;
                    }
                    else
                    {
                        items = new T[0];
                    }
                }
            }
        }
        private const int defaultCapacity = 4;

        public List()
        {
            items = new T[0];
            size = 0;
        }

        public T this[int index]
        {
            get => items[index];
            set
            {
                if (index >= items.Length)
                {
                    items[index] = value;
                }
            }
        }

        /// <summary>
        /// 리스트에 요소를 추가하는 함수
        /// </summary>
        public void Add(T item)
        {
            if (size == items.Length)
            {
                EnsureCapacity();
            }

            items[size] = item;
            size++;
        }

        /// <summary>
        /// 리스트에서 가장 먼저 탐색되는 특정 요소를 제거하는 함수
        /// </summary>
        public bool Remove(T item)
        {
            int index = IndexOf(item);

            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(items, item, 0, size);
        }

        /// <summary>
        /// 리스트에서 특정 인덱스에 있는 요소를 제거하는 함수
        /// </summary>
        public void RemoveAt(int index)
        {
            if (index < size)
            {
                size--;
                Array.Copy(items, index + 1, items, index, size - index);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            items[size] = default(T);
        }

        /// <summary>
        /// 리스트에서 가장 먼저 match 조건에 맞는 요소를 반환하는 함수
        /// </summary>
        public T Find(Predicate<T> match)
        {
            foreach (T item in items)
            {
                if (match(item)) return item;
            }

            return default(T);
        }

        /// <summary>
        /// 리스트에서 match 조건에 맞는 모든 요소를 담은 리스트를 반환하는 함수
        /// </summary>
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();

            foreach (T item in items)
            {
                if (match(item)) result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// 리스트의 Capacity를 보장하는 함수
        /// <br></br>
        /// 배열의 길이가 0이라면 DefaultCapacity인 4로 설정
        /// <br></br>
        /// 0보다 크다면 배열 길이의 2배로 Capacity를 설정
        /// </summary>
        private void EnsureCapacity()
        {
            int doubleCapacity = items.Length == 0 ? defaultCapacity : items.Length * 2;
            Capacity = doubleCapacity;
        }

        // IEnumerator, Foreach 사용
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return items[i];
            }
        }
    }
}
