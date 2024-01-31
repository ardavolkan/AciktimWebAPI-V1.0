using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CategoryImageDto : IDto
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }


    }
}
