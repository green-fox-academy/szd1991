using FrontEndRest.Entities;
using FrontEndRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndRest.Repositories
{
    public class LogRepository : ILogRepository
    {
        private LogContext context;

        public LogRepository(LogContext context)
        {
            this.context = context;
        }

        public void Create(Log log)
        {
            context.Add(log);
            context.SaveChanges();
        }

        public List<Log> Read()
        {
            return context.Logs.ToList();
        }
    }
}
