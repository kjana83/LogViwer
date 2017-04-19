using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer
{
    public class Log
    {
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string WindowsIdentity { get; set; }
        public string AgentSessionId { get; set; }
        public string ProcessName { get; set; }
        public string FileName { get; set; }
        public string JobId { get; set; }
        public int TotalExecutionTimeInSeconds { get; set; }
        public TimeSpan TotalExecutionTime { get; set; }

    }
}
