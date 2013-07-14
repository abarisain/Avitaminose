using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose.Exceptions
{
	class AssemblerException : Exception
	{
		public AssemblerException()
			: base()
		{
		}

		public AssemblerException(string message)
			: base(message)
		{
		}
	}

	class UnknownAssemblerException : Exception
	{
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

	class UnknownOpcodeException : Exception
	{
	}
}
