using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	public class VirtualMachine
	{
		public Stack Stack { get; internal set; }
		public CPU CPU { get; internal set; }
		public Flow Flow { get; internal set; }
		public IBIOS BIOS { get; internal set; }

		public VirtualMachine() : this(new BasicBIOS())
		{		
		}
		
		public VirtualMachine(IBIOS bios)
		{
			Stack = new Stack();
			CPU = new CPU(this);
			Flow = new Flow(this);
			BIOS = bios;
		}
	}
}
