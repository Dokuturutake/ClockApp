namespace ClockApp.Data;
public static class PreferencesInitial
{
	public static void SetPreferences()
	{
		string secondColor = "#FFFBE9";
		string minuteColor = "#E3CAA5";
		string hourColor = "#E3CAA5";
		string indexColor = "#CEAB93";
		string dialColor = "#CEAB93";
		string dialBackgroundColor = "#AD8B73";
		string backgroundColor = "#E3CAA5";


		// 色コードを保存する
		MyPreferences.Set("SecondColor", secondColor);
		MyPreferences.Set("MinuteColor", minuteColor);
		MyPreferences.Set("HourColor", hourColor);
		MyPreferences.Set("IndexColor", indexColor);
		MyPreferences.Set("DialColor", dialColor);
		MyPreferences.Set("DialBackgroundColor", dialBackgroundColor);
		MyPreferences.Set("BackgroundColor", backgroundColor);

		int CurrentHourHandNum = 1;
		MyPreferences.Set("CurrentHourHandNum", CurrentHourHandNum);

		int CurrentSecondHandNum = 1;
		MyPreferences.Set("CurrentSecondHandNum", CurrentSecondHandNum);

		int CurrentIndexNum = 1;
		MyPreferences.Set("CurrentIndexNum", CurrentIndexNum);

		int CurrentMinuteHandNum = 1;
		MyPreferences.Set("CurrentMinuteHandNum", CurrentMinuteHandNum);

		int CurrentDialNum = 1;
		MyPreferences.Set("CurrentDialNum", CurrentDialNum);

		int CurrentDialBackGroundNum = 1;
		MyPreferences.Set("CurrentDialBackGroundNum", CurrentDialBackGroundNum);

		int CurrentBackGroundNum = 1;
		MyPreferences.Set("CurrentBackGroundNum", CurrentBackGroundNum);
	}

}
