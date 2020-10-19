using MeetCfg.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg
{
    class ConsoleDataCollector : IDataCollector
    {
        public Meeting Collect()
        {
            return new Meeting()
            {
                Name = "Корпоратив",
                MeetingDate = new MeetingDate()
                {
                    Durality = TimeSpan.FromHours(2),
                    StartingDate = DateTime.Now
                },
                Priority = 0
            };
        }
    }
}
