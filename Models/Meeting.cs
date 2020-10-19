using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg.Models
{
    public class Meeting
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public int Id { get; set; }
        public MeetingDate MeetingDate { get; set; }
    }
}
