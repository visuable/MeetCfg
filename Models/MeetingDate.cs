using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg.Models
{
    public class MeetingDate
    {
        public Meeting Meeting { get; set; }
        public int MeetingId { get; set; }
        public int MeetingDateId { get; set; }
        public DateTime StartingDate { get; set; }
        public TimeSpan Durality { get; set; }
    }
}
