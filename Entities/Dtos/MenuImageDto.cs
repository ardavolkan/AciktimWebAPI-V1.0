using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class MenuImageDto : IDto
    {
        public string MenuId { get; set; }
        public string ImagePath { get; set; }
    }
}
