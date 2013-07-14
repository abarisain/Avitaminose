using Avitaminose.Exceptions;
using Avitaminose.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	public class Assembler
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

			// Strip anything that is after a ;
			// Note : this makes you unable to have ; in your strings.
			// This will be fixed later
			int commentIndex = line.IndexOf(';');
			if (commentIndex > 0)
			{
				line = line.Substring(0, commentIndex).Trim();
			}
			
			// If there is no space, it's either a label or a no-arg instruction
			if (!line.Contains(' '))
			{
				if (line[line.Length - 1].Equals(':'))
				{
					// Create a new label (or get the formward declaration), memorize its line, add it to the label list (for easy access) and add the instruction.
					// The instruction is a NOP but is assembled for easier debugging
					Label label;
					var labelName = line.Substring(0, line.Length - 1).ToLower();
					if (_labels.TryGetValue(labelName, out label))
					{
						label.Line = _currentLineNumber;
					}
					else
					{
						label = new Label(labelName, _currentLineNumber);
						_labels.Add(label.Name, label);
					}
										
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
				var parameter = line.Substring(spaceIndex + 1);
				object parsedParameter = null;

				// Check if we expect a label
				if (opcode == Opcode.JMP || opcode == Opcode.JNE || opcode == Opcode.JMP)
				{
					Label outLabel;
					var labelName = parameter.ToLower();
					if(_labels.TryGetValue(labelName, out outLabel))
					{
						parsedParameter = outLabel;
					}
					else
					{
						// Forward declaration of a label
						outLabel = new Label(labelName, -1);
						parsedParameter = outLabel;
						_labels.Add(labelName, outLabel);
					}
				}
				else if (opcode == Opcode.PUSH)
				{
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
				}
				else
				{
					throw new AssemblerException("Unexpected argument");
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

		public void Finish()
		{
			foreach (Label label in _labels.Values)
			{
				if(label.Line < 0)
					throw new AssemblerException("Unknown label '" + label.Name + "'");
			}
		}
	}
}
