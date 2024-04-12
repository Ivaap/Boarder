using Boarder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boarder.Loggers
{
    public interface ILogger
    {
        void Log(string value);
    }
}
