using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Collections.Generic
{
    public class Stack<T>
    {
        public Stack()
        {
            _items = new T[0];
            _size = 0;
        }

        private T[] _items;
        private int _size = 0;
        public int Count { get; private set; }
        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value != _items.Length)
                {
                    // 1이상 설정할 경우
                    if (value > 0)
                    {
                        T[] newItems = new T[value];

                        // 이미 스택에 요소가 있다면 복사
                        if (_size > 0)
                        {
                            for (int i = 0; i < _size; i++)
                            {
                                newItems[i] = _items[i];
                            }
                        }
                        _items = newItems;
                    }
                    // 새로 생성되는 경우
                    else
                    {
                        _items = new T[0];
                    }
                }
            }
        }

        /// <summary>
        /// 스택에 요소를 위에 추가하는 함수
        /// </summary>
        public void Push(T item)
        {
            if (_size >= _items.Length)
            {
                EnsureCapacity();
            }

            _items[_size] = item;

            _size++;
            Count++;
        }

        /// <summary>
        /// 스택에서 가장 위에있는 요소를 꺼내며 제거하는 함수
        /// </summary>
        public T Pop()
        {
            T item = _items[_size];

            _items[_size] = default;
            Count--;

            return item;
        }

        public void Clear()
        {
            Count = 0;
        }

        /// <summary>
        /// 스택에 해당 요소와 같은 값을 가진 요소가 있는지 확인합니다.
        /// </summary>
        public bool Contains(T item)
        {
            foreach (T _item in _items)
            {
                if (item.Equals(_item))
                {
                    return true;
                }
            }

            return false;
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
            int doubleCapacity = Capacity == 0 ? 4 : Capacity * 2;
            Capacity = doubleCapacity;
        }

        // 인덱서 Indexer
        public T this[int index]
        {
            get
            {
                if (index > Count)
                {
                    throw new ArgumentOutOfRangeException("Stack의 범위를 벗어났습니다.");
                }
                else
                {
                    return _items[index];
                }
            }
            set
            {
                if (index >= _items.Length)
                {
                    _items[index] = value;
                }
            }
        }

        // IEnumerator, Foreach 사용
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }
    }
}
