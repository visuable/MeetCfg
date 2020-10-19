using MeetCfg.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg
{
    public interface IDataCollector
    {
        Meeting Collect();
    }
}
