using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    internal interface ITask<TResult>
    {
        TResult Perform<T>();
    }
}
