using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RestaurantImage
    {
        public string Id { get; set; }
        public string RestaurantId { get; set; }
        public string ImagePath { get; set; }
    }
}
