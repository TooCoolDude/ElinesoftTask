using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElinesoftTask
{
    public interface IExchange
    {
        decimal GetPrice(string pair);
    }
}
