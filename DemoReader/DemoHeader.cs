using System.IO;

namespace DemoReader
{
	public class DemoHeader
	{
		public string Header { get; }

		public int Protocol { get; }

		public int NetworkProtocol { get; }

		public string ServerName { get; }

		public string ClientName { get; }

		public string MapName { get; }

		public string GameDirectory { get; }

		public float PlaybackTime { get; }

		public int Ticks { get; }

		public int Frames { get; }

		public int SignonLength { get; }

		public DemoHeader(BinaryReader reader)
		{
			Header = new string(reader.ReadChars(8)).Replace("\0", " ").Trim();
			Protocol = reader.ReadInt32();
			NetworkProtocol = reader.ReadInt32();
			ServerName = new string(reader.ReadChars(260)).Replace("\0", " ").Trim();
			ClientName = new string(reader.ReadChars(260)).Replace("\0"," ").Trim();
			MapName = new string(reader.ReadChars(260)).Replace("\0", " ").Trim();
			GameDirectory = new string(reader.ReadChars(260)).Replace("\0", " ").Trim();
			PlaybackTime = reader.ReadSingle();
			Ticks = reader.ReadInt32();
			Frames = reader.ReadInt32();
			SignonLength = reader.ReadInt32();
		}
	}
}
