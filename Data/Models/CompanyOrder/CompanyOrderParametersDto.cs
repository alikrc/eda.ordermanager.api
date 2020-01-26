﻿using eda.ordermanager.api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eda.ordermanager.api.Data.Models.CompanyOrder
{
    public class CompanyOrderParametersDto : PaginationParameters
    {
        public string ExternalOrderNo { get; set; }

        public string QueryString { get; set; }

        public string SortOrder { get; set; }
    }
}
