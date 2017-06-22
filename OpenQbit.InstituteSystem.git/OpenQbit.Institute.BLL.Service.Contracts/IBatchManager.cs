using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Institute.Common.Models;

namespace OpenQbit.Institute.BLL.Service1.Contracts
{
   public  interface IBatchManager
    {

        bool Create(Batch batch);
        Batch FindById(int batchId);
    }
}
