﻿using eda.ordermanager.api.Data.Models.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eda.ordermanager.api.Data.Models.CompanyOrder
{
    public abstract class CompanyOrderForManipulationDto
    {
        public string InternalOrderNo { get; set; }
        public string ExternalOrderNo { get; set; }
        public int VendorId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
        public string Comments { get; set; }
    }
}
