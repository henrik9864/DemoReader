using System.IO;
using System.Net.NetworkInformation;

namespace DemoReader
{
	public class DemoHeader
	{
		public string Header { get; init; }

		public int Protocol { get; init; }

		public int NetworkProtocol { get; init; }

		public string ServerName { get; init; }

		public string ClientName { get; init; }

		public string MapName { get; init; }

		public string GameDirectory { get; init; }

		public float PlaybackTime { get; init; }

		public int Ticks { get; init; }

		public int Frames { get; init; }

		public int SignonLength { get; init; }

		private DemoHeader()
		{

		}

		public static DemoHeader ReadHeader(BinaryReader reader)
		{
			return new DemoHeader()
			{
				Header = new string(reader.ReadChars(8)).Replace("\0", " ").Trim(),
				Protocol = reader.ReadInt32(),
				NetworkProtocol = reader.ReadInt32(),
				ServerName = new string(reader.ReadChars(260)).Replace("\0", " ").Trim(),
				ClientName = new string(reader.ReadChars(260)).Replace("\0", " ").Trim(),
				MapName = new string(reader.ReadChars(260)).Replace("\0", " ").Trim(),
				GameDirectory = new string(reader.ReadChars(260)).Replace("\0", " ").Trim(),
				PlaybackTime = reader.ReadSingle(),
				Ticks = reader.ReadInt32(),
				Frames = reader.ReadInt32(),
				SignonLength = reader.ReadInt32()
		};
		}
	}
}
