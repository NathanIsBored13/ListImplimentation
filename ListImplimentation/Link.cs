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

        public int GetLength(int count)
        {
            count++;
            if (child != null) count = child.GetLength(count);
            return count;
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

        public bool Remove()
        {
            if (child == null) return true;
            else
            {
                if (child.Remove()) child = null;
                return false;
            }
        }

        public void RemoveAt(int position)
        {
            if (position == 0) child = child.GetChild();
            else if (child == null) Console.WriteLine("element does not exist");
            else child.RemoveAt(position - 1);
        }

        public Link GetChild() => child;
    }
}