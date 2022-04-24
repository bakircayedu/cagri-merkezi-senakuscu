using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevv
{
	public interface Queue<E>
	{
		int size();
		bool isEmpty();
		void enqueue(E e);
		E first();
		E dequeue();
	}
}
