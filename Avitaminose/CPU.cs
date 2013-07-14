using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avitaminose.Exceptions;

namespace Avitaminose
{
	class CPU
	{
		private VirtualMachine _vm;
		private Instruction _currentInstruction;

		public CPU(VirtualMachine targetVM)
		{
			_vm = targetVM;
		}

		public void Run()
		{
			while (_vm.Flow.Step())
			{
				_currentInstruction = _vm.Flow.CurrentInstruction;
				switch (_currentInstruction.Opcode)
				{
					case Opcode.NOP:
						// NOP : No Operation.
						// Do nothing
						// Note that a label is a NOP
						break;
					case Opcode.PUSH:
						Push();
						break;
					case Opcode.POP:						
						Pop();
						break;
					case Opcode.ADD:
						Add();
						break;
					case Opcode.SUB:
						Sub();
						break;
					case Opcode.MUL:
						Mul();
						break;
					case Opcode.DIV:
						Div();
						break;
					case Opcode.PRINT:
						Print();
						break;
					case Opcode.AND:
						And();
						break;
					case Opcode.OR:
						Or();
						break;
					case Opcode.XOR:
						Xor();
						break;
					case Opcode.SHL:
						Shl();
						break;
					case Opcode.SHR:
						Shr();
						break;
					case Opcode.CMP:
						Cmp();
						break;
					case Opcode.JMP:
						Jmp();
						break;
					case Opcode.JE:
						Je();
						break;
					case Opcode.JNE:
						Jne();
						break;
					case Opcode.DPL:
						Dpl();
						break;
					default:
						throw new UnknownOpcodeException();						
				}
			}
			_currentInstruction = null;
		}

		public void Push()
		{

		}

		public void Pop()
		{

		}

		public void Add()
		{

		}

		public void Sub()
		{

		}

		public void Mul()
		{

		}

		public void Div()
		{

		}

		public void Print()
		{

		}

		public void And()
		{

		}

		public void Or()
		{

		}

		public void Xor()
		{

		}

		public void Shl()
		{

		}

		public void Shr()
		{

		}

		public void Cmp()
		{

		}

		public void Jmp()
		{

		}

		public void Je()
		{

		}

		public void Jne()
		{

		}

		public void Dpl()
		{

		}
	}
}
