using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Collections.Generic
{
    public class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T> next;
        public LinkedListNode<T> prev;

        public LinkedListNode(T data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }

    public class LinkedList<T>
    {
        /// <summary>
        /// LinkedList의 첫 번째 노드
        /// </summary>
        public LinkedListNode<T> first { get; private set; }

        /// <summary>
        /// LinkedList의 마지막 노드
        /// </summary>
        public LinkedListNode<T> last { get; private set; }

        /// <summary>
        /// LinkedList가 가진 모든 노드의 수
        /// </summary>
        public int count { get; private set; }

        /// <summary>
        /// 앞에서부터 노드를 추가하는 함수
        /// </summary>
        public void AddFirst(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.next = first;
                first.prev = newNode;
                first = newNode;
            }

            count++;
        }

        /// <summary>
        /// 뒤에서부터 노드를 추가하는 함수
        /// </summary>
        public void AddLast(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                newNode.prev = last;

                last = newNode;
            }

            count++;
        }

        /// <summary>
        /// 앞에서부터 데이터와 동일한 값을 가진 첫 번째 노드를 찾는 함수
        /// </summary>
        public LinkedListNode<T> Find(T data)
        {
            var node = first;

            while (node.next != null)
            {
                if (node.data.Equals(data))
                {
                    return node;
                }

                node = node.next;
            }

            return default(LinkedListNode<T>);
        }

        /// <summary>
        /// 뒤에서부터 데이터와 동일한 값을 가진 첫 번째 노드를 찾는 함수
        /// </summary>
        public LinkedListNode<T> FindLast(T data)
        {
            var node = last;

            while (last.prev != null)
            {
                if (node.data.Equals(data))
                {
                    return node;
                }

                node = node.prev;
            }

            return default(LinkedListNode<T>);
        }

        /// <summary>
        /// 첫번째 노드를 제거하는 함수
        /// </summary>
        public void RemoveFirst()
        {
            first = first.next;
            first.prev = null;
            count--;
        }

        /// <summary>
        /// 마지막 노드를 제거하는 함수
        /// </summary>
        public void RemoveLast()
        {
            last = last.prev;
            last.next = null;
            count--;
        }

        /// <summary>
        /// 데이터와 동일한 값을 가진 노드를 제거하는 함수
        /// </summary>
        public bool Remove(T data)
        {
            var node = Find(data);
            if (node != null)
            {
                node.next.prev = node.prev;
                node.prev.next = node.next;
                count--;

                return true;
            }

            return false;
        }

        /// <summary>
        /// 모든 노드를 제거하는 함수
        /// </summary>
        public void Clear()
        {
            first = null;
            last = null;
            count = 0;
        }

        // Foreach
        public IEnumerator<T> GetEnumerator()
        {
            var node = first;
            while (node != null)
            {
                yield return node.data;
                node = node.next;
            }
        }

        /// <summary>
        /// 연결 리스트의 모든 요소를 출력하는 함수
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"노드의 개수 : {count}");

            var node = first;
            while (node != null)
            {
                Console.Write($"{node.data}");
                if (node.next != null)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }

                node = node.next;
            }
        }
    }
}
