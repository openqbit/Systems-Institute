using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Institute.Common.Utils.Log
{
    public interface ILogger
    {
        bool LogError(string err);
    }
}
