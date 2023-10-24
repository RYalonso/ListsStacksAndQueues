using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;

namespace Common
{
    public class IntArrayList : IList
    {
        int[] Values;
        int NumElements = 0;

        public IntArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            this.NumElements = 0;
            this.Values= new int[n];
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i] + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #2: add a new integer to the end of the list
           
            if (NumElements == Values.Length)
            {
                int[] swapArray = new int[Values.Length + 1];
                Values.CopyTo(swapArray, 0);
                Values = swapArray;
            }
            NumElements++;
            Values[NumElements - 1] = value;
     

        }

        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (-1<index && index < NumElements)
            {
                return Values[index];
            }
            else{ return 0; }
        }


        
        public int Count()
        {
            //TODO #4: return the number of elements on the lis
            return NumElements;
        }


       
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if(0<=index && index<NumElements)
            {
                while(index < NumElements)
                {
                    Values[index] = Values[index+1];
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