using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avitaminose.Exceptions;

namespace Avitaminose.Tools
{
	static class StringUtils
	{
		public const char StringDelimiter = '\'';

		/// <summary>
		/// Parses an assembly string, like 'a\n\\b'c into : a <newline> \b'c
		/// </summary>
		/// <param name="source">The string to parse</param>
		/// <returns></returns>
		public static String ParseAssemblyString(String source)
		{
			// Minimum length is 1 : ', first char is ' (which indicates a string). A string can be empty.
			if (source.Length < 1 || source.First() != StringDelimiter)
				throw new AssemblerException("Invalid string");
			// If it's 1 of length, no need to even bother : it's an empty string
			if (source.Length == 1)
				return "";
			// TODO : Handle \n \t etc ...
			return source.Substring(1);
		}
	}
}
