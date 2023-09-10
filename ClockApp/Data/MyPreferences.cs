using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.Data;

public class MyPreferences
{
	public static void Set(string key, string value)
	{
		Preferences.Set(key, value);
	}
	public static void Set(string key, int value)
	{
		Preferences.Set(key, value);
	}

	public static string Get(string key, string defaultValue)
	{
		return Preferences.Get(key, defaultValue);
	}
	public static int Get(string key, int defaultValue)
	{
		return Preferences.Get(key, defaultValue);
	}
}
