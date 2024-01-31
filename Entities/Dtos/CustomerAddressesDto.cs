using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CustomerAddressesDto : IDto
    {
        public string CustomerId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ApartmentNumber { get; set; }
        public string DoorNumber { get; set; }
        public string Address { get; set; }
    }
}
