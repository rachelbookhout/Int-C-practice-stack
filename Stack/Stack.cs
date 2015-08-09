using System;
using System.Collections;

namespace Stack
{
	public class Stack
	{
		private ArrayList stack;

		public Stack()
		{
			stack = new ArrayList ();
		}

		public void Push (Object item)
		{
			if (item != null)
			{
				stack.Add (item);

			}
		}

		public object Pop()
		{
			if (stack.Count == 0) 
			{
				throw new InvalidOperationException("Can't remove an item that doesn't exist in the stack");
			}
			int count = stack.Count;
			object thing = stack [count -1]; 
			stack.RemoveAt(count-1);
			return (thing);
		}

		void Clear()
		{
			stack.Clear ();
		}
			
	}
}

