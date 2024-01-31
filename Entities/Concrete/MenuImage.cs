using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MenuImage : IEntity
    {
        public string Id { get; set; }
        public string MenuId { get; set; }
        public string ImagePath { get; set; }
    }
}
