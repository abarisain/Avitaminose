using Avitaminose.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	class Label
	{
		public string Name { get; internal set; }
		public int Line { get; internal set; }
	}

	class Flow
	{
		public IList<Instruction> Instructions { get; internal set; }
		public int Position { get; internal set; }
		private bool jumpOccured;

		private VirtualMachine _vm;

		public Flow(VirtualMachine targetVm)
		{
			_vm = targetVm;
			Instructions = new List<Instruction>();
			Position = 0;
			jumpOccured = false;
		}

		public Instruction getCurrentInstruction()
		{
			return Instructions[Position];
		}

		public bool CanStep()
		{
			return Instructions.Count() > (Position + 1);
		}

		public bool Step()
		{
			if (!CanStep())
				return false;
			Position++;
			return true;
		}

		public void Jump(int line)
		{
			if (line < 0 || line >= Instructions.Count())
				throw new IllegalJumpException();

			/* Jump one line before, since Step() will make up for that difference.
			 * Note that this implies that getCurrentInstruction will NOT be called after a jump.
			 * This should not cause any problem.
			 */
			Position = line - 1;
		}

		public void Jump(Label label)
		{
			// No need to throw an illegal jump exception since the label already has been verified
			// Jump at the label line, because a label is a nop. We save up some time this way.
			Position = label.Line;
		}
	}
}
