namespace Damn_Generic_List;

public class ArrayList<T> : List<T> {
    private T[] arr;
    private int DEFAULT_ARRAYLIST_SIZE = 0;
    private int length;

    public int size()
    {
        return length;
    }

    public ArrayList()
    {
        arr = new T[DEFAULT_ARRAYLIST_SIZE];
        length = 0;
    }

    public ArrayList(int n)
    {
        arr = new T[n];
        length = n;
    }

    public void add(T element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null)
            {
                arr[i] = element;
                return;
            }
        }

        T[] temp = new T[(length == 0)? 2 : length * 2];
        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }

        temp[arr.Length] = element;
        arr = temp;
        length = (length == 0) ? 2 : length * 2;


    }

    public void put(T element, int position)
    {
        if (position >= length)
        {
            Console.WriteLine("Error going outside the array");
            return;
        }
        arr[position] = element;
    }
    public void remove(int position) 
    {
        T[] temp = new T[length-1];
        int cur = 0;
        for (int i = 0; i < length; i++)
        {
            if (i != position)
            {
                temp[cur++] = arr[i];
            }
        }
        arr = temp;
        length -= 1;
    }

    public int find (T element)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i].Equals(element))
            {
                return i;
            }
        }

        Console.WriteLine("Not found element");
        return -1;
    }

    public T get(int index)
    {

        if (index < 0 || index >= length) {
            Console.WriteLine("Error going outside the array");
        }

        return arr[index];
    }
}
