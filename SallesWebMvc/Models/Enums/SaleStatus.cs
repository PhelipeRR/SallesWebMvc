﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models.Enums
{
    public enum SaleStatus: int
    {
        Pending = 0,
        Biled = 1,
        Canceled = 2,
    }
}