using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg
{
    public class Configurator
    {
        private ApplicationContext context;
        private IDataCollector dataCollector;
        public Configurator(ApplicationContext context, IDataCollector dataCollector)
        {
            this.context = context;
            this.dataCollector = dataCollector;
        }
        public void Configure()
        {
            context.Add(dataCollector.Collect());
            context.SaveChanges();
        }
    }
}
