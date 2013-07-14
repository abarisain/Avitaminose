using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avitaminose.Exceptions;
using Avitaminose.Tools;

namespace Avitaminose
{
	/**
	 * Represents the Virtual Machine's stack.
	 * It is only responsible for pushing and poping variables and induces some typing
	 */
	class Stack
	{

		public Stack<Object> Content { get; private set; }

		public Stack()
		{
			Content = new Stack<Object>();
		}

		public void Push(object value)
		{
			Content.Push(value);
		}

		public Object Peek()
		{
			if (Content.Count == 0)
				throw new EmptyStackException();
			return Content.Peek();
		}

		/**
		 * Only get the value if it matches the requested type
		 * Otherwise, thow a StackCastException.
		 * This is useful for ensuring that somebody doesn't "add" two strings, when it's built for integers
		 */
		public T Peek<T>()
		{
			var val = Peek();
			if (val is T)
				return (T)val;
			throw new StackCastException();
		}

		public Object Pop()
		{
			if (Content.Count == 0)
				throw new EmptyStackException();
			return Content.Pop();
		}

		/**
		 * Only get the value if it matches the requested type
		 * Otherwise, thow a StackCastException.
		 * This is useful for ensuring that somebody doesn't "add" two strings, when it's built for integers
		 */
		public T Pop<T>()
		{
			var val = Pop();
			if (val is T)
				return (T)val;
			throw new StackCastException();
		}
	}
}
