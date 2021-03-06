﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avitaminose
{
	public partial class GUIRunner : Form
	{
		public GUIRunner()
		{
			InitializeComponent();
		}

		private void GUIRunner_Load(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VirtualMachine vm = new VirtualMachine();
			Assembler assembler = new Assembler(vm.Flow);
			foreach (string line in textBoxInput.Text.Split('\n'))
			{
				assembler.AddLineToFlow(assembler.AssembleLine(line));
			}
			assembler.Finish();

			var assembledPrg = new StringBuilder();
			foreach (Instruction instruction in vm.Flow.Instructions)
				assembledPrg.AppendLine(instruction.ToString());
			textBoxAssembledProgram.Text = assembledPrg.ToString();

			vm.CPU.Run();
			textBoxOutput.Text = ((BasicBIOS)vm.BIOS).output;
		}
	}
}
