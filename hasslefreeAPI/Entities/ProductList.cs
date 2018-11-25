﻿using System;
using System.Collections.Generic;

namespace hasslefreeAPI.Entities
{
    public partial class ProductList
    {
        public int ProductListId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public short? Uom { get; set; }
        public decimal? Rate { get; set; }
        public double? Discount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string Source { get; set; }
        public int? ReferenceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        public UserMaster CreatedByNavigation { get; set; }
        public UserMaster ModifiedByNavigation { get; set; }
        public ProductMaster Product { get; set; }
    }
}
