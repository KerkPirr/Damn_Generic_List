namespace Damn_Generic_List;

public class LinkedList<T> : List<T>
	{
		private class Node<Y>
		{
			public Node<Y> previous = null;
			public Node<Y> next = null;
			public Y payload;
		}

		private Node<T> node;



		public LinkedList()
		{
			node = null;

		}

		public void add(T element)
        {
			if (node == null)
			{
				node = new Node<T>();
				node.payload = element;
			}
			else
			{
				Node<T> temp = node;
				while (temp.next != null)
				{
					temp = temp.next;
				}

				temp.next = new Node<T>();
				temp.next.previous = temp;
				temp.next.payload = element;
			}

        }

        public void put(T element, int position)
        {
			Node<T> temp = node;
			

			if (position == 0) {

				node = new Node<T>();
				node.next = temp;
				node.payload = element;
				temp.previous = node;
				return;
			}

			
			int curr = 0;
			while (curr < position)
            {
				if (temp.next == null)
                {
					Console.WriteLine("Erorr");
					return;
                }
				temp = temp.next;
				curr++;
            }

			Node<T> next = temp;
			temp = new Node<T>();
			temp.previous = next.previous;
			temp.next = next;
			temp.payload = element;
			next.previous.next = temp;

        }

        public void remove(int position)
        {

			Node<T> temp = node;
            for (int i = 0; i < position; i++)
            {
				if (temp.next == null)
                {
					Console.WriteLine("Error remove");
					return;
                }
				temp = temp.next;
				
            }
			if (temp.next != null)
            {
				temp.previous.next = temp.next;
            } else
            {
				temp.previous.next = null;
            }

			
        }

        public int find(T element)
        {
			Node<T> temp = node;
			int count = 0;
			while (temp != null && temp.Equals(element))
            {
				temp = temp.next;
				count++;
            }

			if (temp == null)
            {
				return -1;
            }

			return count;
        }

        public T get(int index)
        {
			Node<T> temp = node;
			for (int i = 0; i < index; i++)
			{
				if (temp.next == null)
				{
					Console.WriteLine("Error remove");
					break;
				}
				temp = temp.next;



			}
			return temp.payload;
		}
    }