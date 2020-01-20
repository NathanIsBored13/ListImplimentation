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

        public int GetLength() => head == null ? 0 : head.GetLength(1);

        public int Get(int position)
        {
            int ret;
            if (IsEmpty())
            {
                Console.WriteLine("element does not exist");
                ret = -1;
            }
            else ret = head.Get(position);
            return ret;
        }

        public bool Search(int value)
        {
            bool ret;
            if (IsEmpty())
            {
                Console.WriteLine("element does not exist");
                ret = false;
            }
            else ret = head.Search(value);
            return ret;
        }

        public int Index(int value)
        {
            int ret;
            if (IsEmpty())
            {
                Console.WriteLine("element does not exist");
                ret = -1;
            }
            else ret = head.Index(1, value);
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

        public void Remove(int value)
        {
            if (IsEmpty()) Console.WriteLine("itme does not exist");
            else if (head.Remove(value)) head = head.GetChild();
        }

        public void Pop()
        {
            if (IsEmpty()) Console.WriteLine("list already empty");
            else if (head.Pop()) head = null;
        }

        public void Pop(int position)
        {
            if (position == 0) head = head.GetChild();
            else head.Pop(position - 1);
        }
    }
}