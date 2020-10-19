using MeetCfg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetCfg
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingDate> MeetingDates { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = developmentDb;");
        }
    }
}
