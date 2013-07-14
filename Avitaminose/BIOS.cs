using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avitaminose
{
	public interface IBIOS
	{
		void print(string output);
		void println(string output);
	}

	public class BasicBIOS : IBIOS
	{
		private StringBuilder _outputBuilder;

		public String output
		{
			get
			{
				return _outputBuilder.ToString();
			}
		}

		public BasicBIOS()
		{
			_outputBuilder = new StringBuilder();
		}

		public void print(string output)
		{
			_outputBuilder.Append(output);
		}

		public void println(string output)
		{
			_outputBuilder.AppendLine(output);
		}
	}
}
