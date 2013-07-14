using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose.Exceptions
{
	class AssemblyParsingException : Exception
	{
		public AssemblyParsingException()
			: base()
		{
		}

		public AssemblyParsingException(string message)
			: base(message)
		{
		}
	}

	class EmptyStackException : Exception
	{
	}

	class StackCastException : Exception
	{
	}

	class IllegalJumpException : Exception
	{
	}
}
