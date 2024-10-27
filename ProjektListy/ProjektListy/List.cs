using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektListy
{
    public class List
    {
        public Node head;
        public Node tail;
        public int count;
        public void AddFirst(int liczba)
        {
            Node newNode = new Node(liczba);

            if (count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }

            count += 1;
        }
        public void AddLast(int liczba)
        {
            if (count == 0)
            {
                AddFirst(liczba);
            }
            else
            {
                Node newNode = new Node(liczba);
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
                count += 1;
            }
        }
        public void RemoveFirst()
        {
            if (count == 1)
            {
                head = null;
                tail = null;
                count -= 1;
            }
            else if (count > 1)
            {
                head = head.next;
                count -= 1;
            }
        }
        public void RemoveLast()
        {
            if (count == 1)
            {
                head = null;
                tail = null;
                count -= 1;
            }
            else if (count > 1)
            {
                tail = tail.prev;
                count -= 1;
            }
        }
        public override string ToString()
        {
            string temp = "";
            Node e = head;
            for (int i = 0; i < count; i++)
            {
                temp += e.ToString();
                if (i != count-1) temp += ", ";
                e = e.next;
            }
            return temp;
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
