using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Menu : IEntity
    {
        public string Id { get; set; }
        public string RestaurantId { get; set; }
        public string MenuTitle { get; set; }
        public string MenuDescription { get; set; }
        public string MenuPrice { get; set; }

    }
}
