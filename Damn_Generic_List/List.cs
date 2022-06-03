namespace Damn_Generic_List;
using System.Collections.Generic;
public interface List<T>
{
    public abstract void add(T element);
    public abstract void put(T element, int position);
    public abstract void remove(int position);
    public abstract int find(T element);
    public abstract T get(int index);
    
}