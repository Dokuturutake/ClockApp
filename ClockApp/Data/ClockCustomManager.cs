using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.Data;

class ClockCustomManager
{

    private readonly string rootpath = "wwwroot/MasterDatas";

	// コンストラクタを定義します
    public async Task<ClockParts> GetClockParts()
    {
        ClockParts CP = new();
            // 各プロパティに対応するCSVファイルのパスを指定します
            string hourHandsPath = "MasterHourHand.csv";
            string minuteHandsPath = "MasterMinuteHand.csv";
            string secondHandsPath = "MasterSecondHand.csv";
            string indexHandsPath = "MasterIndex.csv";
            string dialsPath = "MasterDial.csv";
            string dialBackgroundsPath = "MasterDialBackGround.csv";
            string backgroundsPath = "MasterBackGround.csv";

            // 各プロパティにCSVファイルから読み込んだデータを代入します
            CP.HourHands = await ReadCsv(hourHandsPath);
            CP.MinuteHands = await ReadCsv(minuteHandsPath);
            CP.SecondHands = await ReadCsv(secondHandsPath);
            CP.Index = await ReadCsv(indexHandsPath);
            CP.Dials = await ReadCsv(dialsPath);
            CP.DialBackgrounds = await ReadCsv(dialBackgroundsPath);
            CP.Backgrounds = await ReadCsv(backgroundsPath);
			return CP;
	}

    

    private async Task<ClockPart[]> ReadCsv(string csvPath)
    {
        var clockPartList = new List<ClockPart>();
        var fullPath = Path.Combine(rootpath, csvPath);
        using var stream = await FileSystem.Current.OpenAppPackageFileAsync(fullPath);
		using var reader = new StreamReader(stream);
		// 最初の行はヘッダーなので読み飛ばします
		reader.ReadLine();
		while (!reader.EndOfStream)
		{
			// 行をカンマで分割して配列にします
			string[] values = reader.ReadLine().Split(',');
			// 配列の要素をClockPartクラスのプロパティに割り当てます
			ClockPart clockPart = new()
			{
				ID = int.Parse(values[0]),
				NAME = values[1],
				Path = values[2]
			};
			// リストに追加します
			clockPartList.Add(clockPart);
		}

		return clockPartList.ToArray();


	}
}
