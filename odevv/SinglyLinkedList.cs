using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevv
{
	public class SinglyLinkedList<E>
	{
		
		private class Node<E>
		{
			internal E element; 
			internal Node<E> next; 
			public Node(E e, Node<E> n)
			{
				element = e;
				next = n;
			}
			public virtual E Element
			{
				get
				{
					return element;
				}
			}
			public virtual Node<E> Next
			{
				get
				{
					return next;
				}
				set
				{
					next = value;
				}
			}
		}

        internal bool ismpty()
        {
            throw new NotImplementedException();
        }

        private Node<E> head = null; 
		private Node<E> tail = null; 
									 
		private int size_Conflict = 0; 
		public SinglyLinkedList()
		{
		} 
		public virtual int size()
		{
			return size_Conflict;
		}
		public virtual bool Empty
		{
			get
			{
				return size_Conflict == 0;
			}
		}
		
		public virtual E first()
		{
			if (Empty)
			{
				return default(E);
			}
			return head.Element;
		}

		
		public virtual E last()
		{
			if (Empty)
			{
				return default(E);
			}
			return tail.Element;
		}

		
		public virtual void addFirst(E e)
		{
			head = new Node<E>(e, head);
			if (size_Conflict == 0)
			{
				tail = head; 
			}
			size_Conflict++;
		}
		
		public virtual void addLast(E e)
		{
			Node<E> newest = new Node<E>(e, null); 
			if (Empty)
			{
				head = newest; 
			}
			else
			{
				tail.Next = newest; 
			}
			tail = newest;
			size_Conflict++;
		}
		
		public virtual E removeFirst()
		{
			if (Empty) 
			{
				return default(E);
			}
			E answer = head.Element;
			head = head.Next; 
			size_Conflict--;
			if (size_Conflict == 0)
			{
				tail = null; 
			}
			return answer;
		}
	}

}
