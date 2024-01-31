using Core.Entities;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerAddresses : IEntity
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Street { get; set; }
        public string ApartmentNumber { get; set; }
        public string DoorNumber { get; set; }
        public string Address { get; set; }


    }
}
