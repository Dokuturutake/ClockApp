using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.Data;

static public class ColorSaveLoad
{
	public static void SaveColor(string color, string path){
		color = color.Replace("#", "");
		IntBinarySaveRoad.SaveIntBinary(Convert.ToInt32(color, 16), path);
	}

	public static string LoadColor(string path)
	{
		var num = IntBinarySaveRoad.LoadIntBinary(path);
		string color = "#" + num.ToString("X").PadLeft(3, '0');
		return color;
	}

}
