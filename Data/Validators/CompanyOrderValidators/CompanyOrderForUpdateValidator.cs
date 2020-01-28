﻿using eda.ordermanager.api.Data.Models.CompanyOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eda.ordermanager.api.Data.Validators.CompanyOrderValidators
{
    public class CompanyOrderForUpdateValidator : CompanyOrderForManipulationValidator<CompanyOrderForUpdateDto>
    {
        public CompanyOrderForUpdateValidator()
        {
        }
    }
}
