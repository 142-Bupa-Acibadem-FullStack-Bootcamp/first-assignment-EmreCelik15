﻿using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public partial class DtoOrderSubtotal : DtoBase
    {
        public DtoOrderSubtotal()
        {

        }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
