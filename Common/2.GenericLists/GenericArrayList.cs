using System;
namespace Common
{
    public class GenericArrayList<T> : IGenericList<T> 
    {
        T[] Values;
        int NumElements = 0;

        public GenericArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            NumElements = 0;
            Values = new T[NumElements];
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        

        public void Add(T value)
        {
            //TODO #2: add a new element to the end of the list

            if (NumElements == Values.Length)
            {
                T[] swapArray = new T[Values.Length + 1];
                Values.CopyTo(swapArray, 0);
                Values = swapArray;
            }
            NumElements++;
            Values[NumElements - 1] = value;
        }

        public T Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
            if (-1 < index && index < NumElements)
            {
                return Values[index];
            }
            else { return default; }
        }

        public int Count()
        {
            //TODO #4: return the number of elements on the list

            return NumElements;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (0 <= index && index < NumElements)
            {
                while (index < NumElements-1)
                {
                    Values[index] = Values[index + 1];
                    index++;
                }
                
                NumElements--;
            }
        }

        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            NumElements = 0;
        }
    }
}