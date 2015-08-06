using System;
using System.Collections;

namespace Stack
{
	public class Stack
	{
		private ArrayList stack;

		private Stack()
		{
			stack = new ArrayList ();
		}

		private void Push (Object item)
		{
			if (!item == null) 
			{
				stack.Add (item);

			}
		}
		//void Push(object obj)
			//store the given object on top of the stack (need to use object type)
			// take in scenerior that null is passed in - do not store it

		//object Pop()
			// removes the object at the top of the stack and returns it
		    //take into account that you should throw a InvalidOperationExpection if its called on a empty stack

		//void Clear()
			//removes all objects from the stack

	}
}

