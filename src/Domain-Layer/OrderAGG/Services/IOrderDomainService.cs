﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.OrderAGG.Services
{
    public interface IOrderDomainService
    {
        bool ProductNotExsite(long ProductId);
    }
}