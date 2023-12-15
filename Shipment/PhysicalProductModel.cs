using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    public class PhysicalProductModel : IProductModel
    {

        public string Name { get; set; }

        public bool HasBeenSent { get; private set; }

        public void Shipment(CustomerModel customer)
        {
            Console.WriteLine($"Sending {Name} to {customer.FirstName} in {customer.Address} at the Adress: {customer.Address}");
            HasBeenSent = true;
        }
    }
}
