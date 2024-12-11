using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    internal class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public string Perform<T>()
        {
            return $"Email sent to {Recipient} with message {Message}";
        }
    }
}
