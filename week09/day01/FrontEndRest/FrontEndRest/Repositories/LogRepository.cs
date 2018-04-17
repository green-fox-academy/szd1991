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

        public void Archive(string endpoint, string data)
        {
            context.Add(new Log {
                Endpoint = endpoint,
                Data = data,
                CreatedAt = DateTime.Now
            });
            context.SaveChanges();
        }

        public List<Log> ReadAll()
        {
            return context.Logs.ToList();
        }
    }
}
