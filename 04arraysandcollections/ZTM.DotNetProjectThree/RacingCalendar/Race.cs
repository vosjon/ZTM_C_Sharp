using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingCalendar;

internal class Race
{
    public Race(string name, string date, string track)
    {
        Name = name;
        Date = date;
        Track = track;
    }
    public string Name { get; set; }
    public string Date { get; set; }
    public string Track { get; set; }
}
