using PrimeTable.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTable.Domain.Interfaces
{
    public interface IMultiplicationTableService
    {
        MultiplicationTable CreateMultiplicationTable(int size);

    }
}
