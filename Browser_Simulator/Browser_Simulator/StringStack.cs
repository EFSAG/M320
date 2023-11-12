using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class StringStack
    {
        private string[] values;
        private int index;

        public StringStack(int capacity)
        {
            values = new string[capacity];
        }

        public void Push(string value)
        {
            if (index < values.Length)
            {
                values[index++] = value;
            }
            else
            {
                Console.WriteLine("Stack is full. Unable to push.");
            }
        }

        public string Pop()
        {
            if (index > 0)
            {
                return values[--index];
            }
            else
            {
                Console.WriteLine("Stack is empty. Unable to pop.");
                return null;
            }
        }

        public string Peek()
        {
            if (index > 0)
            {
                return values[index - 1];
            }
            else
            {
                Console.WriteLine("Stack is empty. Unable to peek.");
                return null;
            }
        }

        public void Swap()
        {
            if (index >= 2)
            {
                string temp = values[index - 1];
                values[index - 1] = values[index - 2];
                values[index - 2] = temp;
            }
            else
            {
                Console.WriteLine("Insufficient elements to swap.");
            }
        }

        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty
        {
            get { return index == 0; }
        }

        public int Count
        {
            get { return index; }
        }

        public bool IsFull
        {
            get { return index == values.Length; }
        }

        public override string ToString()
        {
            return string.Join(", ", values, 0, index);
        }
    }
}
