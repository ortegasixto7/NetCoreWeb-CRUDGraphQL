﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWeb_CRUDGraphQL.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }
    }   
}
