using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT_Lab04
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;

        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }

        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public int Count()
        {
            int count = 0;
            IntNode p = first;
            while (p != null)
            {
                count++;
                p = p.Next;
            }
            return count;
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Value (0 to stop): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode SearchX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                {
                    Console.WriteLine($"Value {x} found in the list.");
                    return p;
                }
                p = p.Next;
            }
            Console.WriteLine($"Value {x} not found in the list.");
            return null;
        }
        public IntNode GetMax()
        {
            if (IsEmpty()) return null;

            IntNode maxNode = first;
            IntNode p = first.Next;

            while (p != null)
            {
                if (p.Data > maxNode!.Data)
                {
                    maxNode = p;
                }
                p = p.Next;
            }
            Console.WriteLine($"Max value: {maxNode.Data}");
            return maxNode;
        }

        public IntNode GetMin()
        {
            if (IsEmpty()) return null;

            IntNode minNode = first;
            IntNode p = first?.Next;

            while (p != null)
            {
                if (p.Data < minNode!.Data)
                {
                    minNode = p;
                }
                p = p.Next;
            }
            Console.WriteLine($"Min value: {minNode.Data}");
            return minNode;
        }
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            IntNode p = first;

            while (p != null)
            {
                if (p.Data % 2 == 0)
                {
                    evenList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;
            }
            evenList.ShowList();
            return evenList;
        }
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode p = first;

            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    oddList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;
            }
            oddList.ShowList();
            return oddList;
        }
    }
}
