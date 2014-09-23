namespace _GenericList
{
    using System;
    using System.Text;

    [Version(1, 0)]
    class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }

                T result = elements[index];
                return result;
            }
        }

        public void Add(T element)
        {
            if (count >= this.elements.Length)
            {
                this.Resize(this.elements);
            }

            this.elements[count] = element;
            count++;
        }

        public void InsertByIndex(int index, T element)
        {
            if (index > count + 1 || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
            }
            else if (index == count + 1)
            {
                this.Add(element);
            }
            else
            {
                // clones the list
                T[] tempList = new T[this.elements.Length];
                for (int i = 0; i < tempList.Length; i++)
                {
                    tempList[i] = this.elements[i];
                }

                int counter = 0;
                this.elements = new T[tempList.Length + 1];
                for (int i = 0; i < this.elements.Length; i++)
                {
                    if (i != index)
                    {
                        this.elements[i] = tempList[counter];
                        counter++;
                    }
                    else
                    {
                        this.elements[i] = element;
                    }
                }
                this.count++;
            }
        }

        public void RemoveByIndex(int index)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < this.elements.Length; i++)
                {
                    if (i != index)
                    {
                        this.elements[counter] = this.elements[i];
                        counter++;
                    }
                }
            }

            this.count--;
        }

        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.count = 0;
        }

        public int FindElement(T element)
        {
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public bool Contains(T element)
        {
            if (this.FindElement(element) != -1)
            {
                return true;
            }

            return false;
        }

        private void Resize(T[] elements)
        {
            this.elements = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements[i] = elements[i];
            }
        }

        public T Min()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T min = this.elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i] + " ");
            }

            return result.ToString();
        }
    }
}