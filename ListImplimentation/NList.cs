using System;

namespace ListImplimentation
{
    class NList
    {
        Link head;
        public NList()
        {
            head = null;
        }

        public bool IsEmpty() => head == null;

        public int GetLength()
        {
            int i = 0;
            if (!IsEmpty()) i = head.GetLength(i);
            return i;
        }

        public int Get(int position)
        {
            int ret;
            if (IsEmpty())
            {
                Console.WriteLine("list empty");
                ret = -1;
            }
            else ret = head.Get(position);
            return ret;
        }

        public int[] ToArray()
        {
            int[] ret = new int[GetLength()];
            if (!IsEmpty()) head.ToArray(ret, 0);
            return ret;
        }

        public void Set(int position, int value)
        {
            if (IsEmpty()) Console.WriteLine("element does not exist");
            else head.Set(position, value);
        }

        public void Add(int value)
        {
            if (IsEmpty()) head = new Link(value);
            else head.Add(value);
        }

        public void Insert(int position, int value)
        {
            if (position == 0) head = new Link(value, head);
            else head.Insert(position - 1, value);
        }

        public void Clear()
        {
            head = null;
        }

        public void Remove()
        {
            if (IsEmpty()) Console.WriteLine("list already empty");
            else if (head.Remove()) head = null;
        }

        public void RemoveAt(int position)
        {
            if (position == 0) head = head.GetChild();
            else head.RemoveAt(position - 1);
        }
    }
}