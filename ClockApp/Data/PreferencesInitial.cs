namespace ClockApp.Data;
public static class PreferencesInitial
{
	public static void SetPreferences()
	{
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
