using System;

namespace ListImplimentation
{
    class Link
    {
        private int value;
        private Link child;
        public Link(int value, Link child = null)
        {
            this.value = value;
            this.child = child;
        }

        public int GetLength(int count) => child == null ? count : child.GetLength(count + 1);

        public bool Search(int value) => value == this.value ? true : (child == null ? false : child.Search(value));

        public int Index (int index, int value)
        {
            int ret;
            if (value == this.value) ret = index;
            else if (child != null) ret = child.Index(index + 1, value);
            else
            {
                Console.WriteLine("element does not exist");
                ret = -1;
            }
            return ret;
        }

        public int Get(int position)
        {
            int ret;
            if (position == 0) ret = value;
            else if (child != null) ret = child.Get(position - 1);
            else
            {
                Console.WriteLine("element does not exist");
                ret = -1;
            }
            return ret;
        }

        public void ToArray(int[] ret, int position)
        {
            ret[position] = value;
            if (child != null) child.ToArray(ret, position + 1);
        }

        public void Set(int position, int value)
        {
            if (position == 0) this.value = value;
            else if (child != null) child.Set(position - 1, value);
            else Console.WriteLine("element does not exist");
        }

        public void Add(int value)
        {
            if (child == null) child = new Link(value);
            else child.Add(value);
        }

        public void Insert(int position, int value)
        {
            if (position == 0) child = new Link(value, child);
            else child.Insert(position - 1, value);
        }

        public bool Remove(int value)
        {
            bool ret;
            if (value == this.value) ret = true;
            else
            {
                if (child.Remove(value)) child = child.GetChild();
                ret = false;
            }
            return ret;
        }

        public bool Pop()
        {
            bool ret;
            if (child == null) ret = true;
            else
            {
                if (child.Pop()) child = null;
                ret = false;
            }
            return ret;
        }

        public void Pop(int position)
        {
            if (position == 0) child = child.GetChild();
            else if (child == null) Console.WriteLine("element does not exist");
            else child.Pop(position - 1);
        }

        public Link GetChild() => child;
    }
}