﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CateName { get; set; }
        public List<Product> Products { get; set; }
    }
}
