using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    public class DigitalProduct : IProductModel
    {

        public string Name { get; set; }

        public bool HasBeenSent { get; private set; } = false;

        public void Shipment(CustomerModel customer)
        {
            if (!HasBeenSent)
            {
                Console.WriteLine($"Emailing {Name} to {customer.FirstName} in {customer.EmailAdress}");
                HasBeenSent = true; 
            }
        }
    }
}
