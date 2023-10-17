using System;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        
        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            if (First == null)
            {
                First = new IntListNode(value);
            }
            else 
            {
                    IntListNode node = First;
                    while(node.Next != null) { 
                        node = node.Next;
                    }
                    node.Next = new IntListNode(value);
               
            }
            
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            IntListNode node = First;
            int i = 0
            while (i < index && node=!null)
            { 
               node = node.Next;
               i++ 
            }
            return node;
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (-1<index <= Count()) 
            { 
                return GetNode(index).Value; 
            }
            else { return 0; }
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            IntListNode node = First;
            int count= 0;
            while(node=!null)
            {
                node = node.Next;
                count++;

            }
            return count;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            
            if (-1 < index <= Count())
            {
                GetNode(index - 1).Next = GetNode(index).Next;
            }

        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            IntListNode node = First;
            if (node != null) node = null;
            
        }
    }
}