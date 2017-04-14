﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Domain.Entities;

namespace BookShop.Domain.Abstract
{
    public interface IOrderHandler
    {
        void HandleOrder(Basket basket, DeliveryInfo deliveryInfo);
    }
}
