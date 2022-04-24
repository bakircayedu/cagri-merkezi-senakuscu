using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevv
{
	using System.Collections.Generic;

	public class LinkedQueue<E> : LinkedList<E>
	{
		private SinglyLinkedList<E> list = new SinglyLinkedList<E>(); 
		public LinkedQueue()
		{
		} 
		public virtual int size()
		{
			return list.size();
		}
		public virtual bool Empty
		{
			get
			{
				return list.ismpty();
			}
		}
		public virtual void enqueue(E element)
		{
			list.addLast(element);
		}
		public virtual E first()
		{
			return list.first();
		}
		public virtual E dequeue()
		{
			return list.removeFirst();
		}

        internal bool isEmpty()
        {
            throw new NotImplementedException();
        }
    }

}
