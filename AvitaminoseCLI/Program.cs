using Avitaminose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvitaminoseCLI
{
	class Program
	{
		static void Main(string[] args)
		{
			System.IO.StreamReader programFile = new System.IO.StreamReader(args[1]);
			string program = programFile.ReadToEnd();
			programFile.Close();

			VirtualMachine vm = new VirtualMachine();
			Assembler assembler = new Assembler(vm.Flow);
			foreach (string line in program.Split('\n'))
			{
				assembler.AddLineToFlow(assembler.AssembleLine(line));
			}
			assembler.Finish();

			vm.CPU.Run();
			Console.WriteLine(((BasicBIOS)vm.BIOS).output);
		}
	}
}
