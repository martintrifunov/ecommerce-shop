﻿using Shop.Web.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProduct(BaseEntity model);
    }
}
