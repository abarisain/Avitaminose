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
			_vm.Stack.Push(((ParametrizedInstruction) _currentInstruction).Parameter);
		}

		/// <summary>
		/// Pops the top of the stack. Doesn't use the returned value.
		/// </summary>
		public void Pop()
		{
			_vm.Stack.Pop();
		}

		public void Add()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(a + b);
		}

		public void Sub()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(a - b);
		}

		public void Mul()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push((int) (a * b));
		}

		public void Div()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push((int) (b / a));
		}

		public void Print()
		{
			var a = _vm.Stack.Peek();

			_vm.BIOS.print(a.ToString());
		}

		/// <summary>
		/// Temporary, until escaped characters are printable
		/// </summary>
		public void Println()
		{
			var a = _vm.Stack.Peek();

			_vm.BIOS.println(a.ToString());
		}

		public void And()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b & a);
		}

		public void Or()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b | a);
		}

		public void Xor()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b ^ a);
		}

		public void Shl()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b << a);
		}

		public void Shr()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b >> a);
		}

		public void Cmp()
		{
			var a = _vm.Stack.Pop<int>();
			var b = _vm.Stack.Pop<int>();

			_vm.Stack.Push(b == a ? 1 : 0);
		}

		public void Jmp()
		{
			_vm.Flow.Jump((Label)((ParametrizedInstruction)_currentInstruction).Parameter);
		}

		public void Je()
		{
			var a = _vm.Stack.Pop<int>();
			if (a == 1)
				Jmp();
		}

		public void Jne()
		{
			var a = _vm.Stack.Pop<int>();
			if (a == 0)
				Jmp();
		}

		public void Dpl()
		{
			var a = _vm.Stack.Pop<int>();
			_vm.Stack.Push(a);
			_vm.Stack.Push(a);
		}
	}
}
