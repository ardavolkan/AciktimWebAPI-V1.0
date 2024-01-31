using Core.Entities;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RestaurantName { get; set; }
        public string OrderDescription { get; set; }
        public string Address { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; } 

    }
}
