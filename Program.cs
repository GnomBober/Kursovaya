using System.Text;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    public class Queue<T> where T : class
    {
        const int n = 10;
        private T[] items = new T[n];
        private int startIndex, endIndex, count;

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public bool IsFull
        {
            get { return count == items.Length; }
        }
        public void Add(T item)
        {
            if (IsFull)
                throw new InvalidOperationException("Заполнен");
            items[endIndex++] = item;
            if (endIndex == n)
                endIndex = 0;
            count++;
        }
        public T Del()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[startIndex];
            items[startIndex++] = default(T);
            if (startIndex == n)
                startIndex = 0;
            --count;
            return item;
        }
        public override string ToString()
        {
            var stringbuilder = new StringBuilder();
            foreach (var item in items)
            {
                stringbuilder.Append($"{{{item}}}");
            }
            return stringbuilder.ToString();
        }

        public void Count(T name)
        {
            int b = 0;
            foreach(T a in items)
            {
                if (a == name)
                {
                   
                }
            }
        }

    }
}

