using FrontEndRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndRest.Repositories
{
    public interface ILogRepository
    {
        void Create(Log log);
        List<Log> Read();
    }
}
