namespace Defining_Classes___Part_2
{
using System;
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] data;
        private int nextIndex = 0;

        public GenericList(int capacity)
        {
            this.data = new T[capacity];
        }

        public void AddElement(T item)
        {
            if (this.nextIndex == this.data.Length)
            {
                this.AutoGrow();
            }
            this.data[nextIndex] = item;
            nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index];
            }
            private set { this.data[index] = value; }
        }

        public void RemoveElementByIndex(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.nextIndex--;
            this.data[nextIndex] = default(T);
        }

        public void InsertElementAtIndex(int index, T element)
        {
            if (this.nextIndex == this.data.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.data[i] = this.data[i - 1];
            }
            this.data[index] = element;
            this.nextIndex++;
        }

        public void ClearList()
        {
            this.data = new T[nextIndex];
        }

        public override string ToString()
        {
            return string.Join(", ", this.data);
        }

        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }

        public T Min()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }
            T min = this.data[0];

            foreach (T item in this.data)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public T Max()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }
            T max = this.data[0];

            foreach (T item in this.data)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

    }
}
