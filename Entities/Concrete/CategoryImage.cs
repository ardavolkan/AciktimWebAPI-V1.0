using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CategoryImage : IEntity
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string ImagePath { get; set; }

    }
}
