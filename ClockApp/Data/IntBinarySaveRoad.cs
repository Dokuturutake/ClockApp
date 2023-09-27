using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.Data;

class IntBinarySaveRoad
{

public static bool SaveIntBinary(int data, string path)
{
	string filePath = Path.Combine(FileSystem.AppDataDirectory, path);

	using FileStream fs = File.Create(filePath);
	using BinaryWriter bw = new(fs);
	bw.Write(data);

	return true;
}

public static int LoadIntBinary(string path)
{
	int number;
	string filePath = Path.Combine(FileSystem.AppDataDirectory, path);
	using(FileStream fs = File.OpenRead(filePath))
	{
		using BinaryReader br = new(fs);
		number = br.ReadInt32();
	}
	return number;
}
}
