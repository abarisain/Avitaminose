using Avitaminose.Exceptions;
using Avitaminose.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	class Assembler
	{
		private Flow _flow;
		private Dictionary<string, Label> _labels;
		private int _currentLineNumber;

		public Assembler(Flow targetFlow)
		{
			_flow = targetFlow;
			_labels = new Dictionary<string, Label>();
			Reset();
		}

		public void Reset()
		{
			_labels.Clear();
			_flow.Clear();
			// Since it will be incremented at the first line parse, init it at -1. Just like Flow.Step()
			_currentLineNumber = -1;
		}

		public Opcode GetOpcodeForString(string instruction)
		{
			Opcode targetOpcode;
			if(!Enum.TryParse(instruction, true, out targetOpcode))
				throw new AssemblerException("Unknown opcode '" + instruction + "'");
			return targetOpcode;
		}

		public Instruction AssembleLine(string line)
		{
			line = line.Trim();

			// Ignore empty lines
			if (line.Length == 0)
				return null;

			// Ignore comments
			if (line[0] == ';')
				return null;

			// Now we're sure it's a line we are going to parse and add
			_currentLineNumber++;
			
			// If there is no space, it's either a label or a no-arg instruction
			if (!line.Contains(' '))
			{
				if (line[line.Length - 1].Equals(':'))
				{
					// Create a new label, memorize its line, add it to the label list (for easy access) and add the instruction.
					// The instruction is a NOP but is assembled for easier debugging
					var label = new Label(line.Substring(0, line.Length - 1), _currentLineNumber);
					_labels.Add(label.Name, label);
					return new LabelInstruction(label);
				}

				// Labels have been handled, we are now sure we are in a no-arg instruction
				return new Instruction(GetOpcodeForString(line));
			}
			else
			{
				// Split the string on the first space
				var spaceIndex = line.IndexOf(' ');
				var opcode = GetOpcodeForString(line.Substring(0, spaceIndex));
				var parameter = line.Substring(spaceIndex);
				object parsedParameter = null;

				try
				{
					// If the first char is ', then we have a string to parse, otherwise it's a number
					if (parameter.First() == StringUtils.StringDelimiter)
					{
						parsedParameter = StringUtils.ParseAssemblyString(parameter);
					}
					else
					{
						// TODO : Parse more format numbers (see vitamine bug 11)
						parsedParameter = int.Parse(parameter);
					}
				}
				catch (Exception)
				{
					throw new AssemblerException("Error while parsing line parameter");
				}

				return new ParametrizedInstruction(opcode, parsedParameter);
			}

			throw new UnknownAssemblerException();
		}

		public void AddLineToFlow(Instruction assembledInstruction)
		{
			if (assembledInstruction != null)
			{
				_flow.Instructions.Add(assembledInstruction);
			}
		}
	}
}
