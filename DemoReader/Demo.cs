using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace DemoReader
{
	public class Demo
	{
		DemoHeader Header { get; init; }

		public static Demo Parse(string file)
		{
			DemoHeader header;

			using (FileStream stream = new FileStream(file, FileMode.Open))
			using (BinaryReader reader = new BinaryReader(stream))
			{
				header = DemoHeader.ReadHeader(reader);

				Console.WriteLine(header.Protocol);
				Console.WriteLine(header.NetworkProtocol);
				Console.WriteLine((int)reader.ReadChar());
			}

			return new Demo()
			{
				Header = header
			};
		}
	}

	public class DemoPacket
	{

	}
}
