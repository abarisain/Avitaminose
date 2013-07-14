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
	}

	class ParametrizedInstruction<T> : Instruction
	{
		public T Parameter { get; set; }

		public ParametrizedInstruction(Opcode opcode, T parameter)
			: base(opcode)
		{
			Parameter = parameter;
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
