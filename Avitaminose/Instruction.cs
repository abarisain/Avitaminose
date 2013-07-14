using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	class Instruction
	{
		public Opcode Opcode { get; set; }

		public Instruction(Opcode opcode)
		{
			Opcode = opcode;			
		}

		public override string ToString()
		{
			return Opcode.ToString();
		}
	}

	class ParametrizedInstruction<T> : Instruction
	{
		public T Parameter { get; set; }

		public ParametrizedInstruction(Opcode opcode, T parameter)
			: base(opcode)
		{
			Parameter = parameter;
		}

		public override string ToString()
		{
			string value = null;
			if (typeof(T) == typeof(int) || typeof(T) == typeof(string))
			{
				value = Parameter.ToString();
			}
			else
			{
				value = null;
			}
			return base.ToString() + " ";
		}
	}

	class LabelInstruction : Instruction
	{
		public string Name { get; set; }

		public LabelInstruction(Opcode opcode, String name)
			: base(opcode)
		{
			Name = name;
		}

		public override string ToString()
		{
			return Name + ":";
		}
	}

	enum Opcode
	{
		NOP,
		PUSH,
		POP,
		ADD,
		SUB,
		MUL,
		DIV,
		PRINT,
		AND,
		OR,
		XOR,
		SHL,
		SHR,
		CMP,
		JMP,
		JE,
		JNE,
		DPL
	}
}
