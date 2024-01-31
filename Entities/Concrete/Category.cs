﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
    }
}
