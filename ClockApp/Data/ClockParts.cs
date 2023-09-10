using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.Data;

public class ClockParts
{
	public ClockPart[] HourHands { get; set; }
	public ClockPart[] MinuteHands { get; set; }
	public ClockPart[] SecondHands { get;set;  }
	public ClockPart[] Index { get;set;  }
	public ClockPart[] Dials { get;set;  }
	public ClockPart[] DialBackgrounds { get;set;  }
	public ClockPart[] Backgrounds { get;set;  }

}
