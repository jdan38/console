﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.AspNetCore.Models
{
    public interface IOrderRepo
    {
        void CreateOrder(Order order);
    }
}
