using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }

        public string Perform<T>()
        {
            return $"Report {ReportName} has been generated sucessfully!";
        }
    }
}
