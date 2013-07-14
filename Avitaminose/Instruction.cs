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

	class ParametrizedInstruction : Instruction
	{
		public object Parameter { get; set; }

		public ParametrizedInstruction(Opcode opcode, object parameter)
			: base(opcode)
		{
			Parameter = parameter;
		}

		public override string ToString()
		{
			return base.ToString() + " " + Parameter.ToString();
		}
	}

	class LabelInstruction : Instruction
	{
		public string Name { get; set; }

		public LabelInstruction(String name)
			: base(Opcode.NOP)
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
