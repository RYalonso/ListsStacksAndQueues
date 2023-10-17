using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        if (First == null)
        {
            First = new GenericListNode<T>(value);
        }
        else
        {
            GenericListNode<T> node = First;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new GenericListNode<T>(value);

        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        GenericListNode<T> node = First;
        int i = 0;
        while ((i < index) && (node != null))
        {
            node = node.Next;
            i++;
        }
        return node;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        if (-1 < index && index <= Count())
        {
            return FindNode(index).Value;
        }
        else { return default; }
        
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list
        GenericListNode<T> node = First;
        int count = 0;
        while (node != null)
        {
            node = node.Next;
            count++;

        }
        return count;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (-1 < index && index < Count())
        {
            if (index != 0) FindNode(index - 1).Next = FindNode(index).Next;
            else { First = First.Next; }
        }
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}