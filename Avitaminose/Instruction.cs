﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	public class Instruction
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

	public class ParametrizedInstruction : Instruction
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

	public class LabelInstruction : Instruction
	{
		public Label Label { get; set; }

		public LabelInstruction(Label label)
			: base(Opcode.NOP)
		{
			Label = label;
		}

		public override string ToString()
		{
			return Label.Name + ":";
		}
	}

	public enum Opcode
	{
		NOP,
		PUSH,
		POP,
		ADD,
		SUB,
		MUL,
		DIV,
		PRINT,
		PRINTLN,
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
