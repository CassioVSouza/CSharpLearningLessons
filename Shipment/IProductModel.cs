using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    public interface IProductModel
    {
        string Name { get; }
        bool HasBeenSent { get; }
        void Shipment(CustomerModel customer);
    }
}
