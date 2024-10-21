using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw04
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;
        public void AddFirst(int liczba)
        {
            Node temp = head;
            head = new Node(liczba);
            head.next = temp;
            count += 1;
        }
        public void AddLast(int liczba)
        {
            Node temp = tail;
            tail = new Node(liczba);
            tail.prev = temp;
            count += 1;
        }
        public void RemoveFirst()
        {
            head = head.next;
            count -= 1;
        }
        public void RemoveLast()
        {
            tail = tail.prev;
            count -= 1;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Node Get(int index)
        {
            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
