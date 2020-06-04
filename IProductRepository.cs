﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Core
{
    public interface IProductRepository
    {

        void Add(Product p);

        void Edit(Product p);

        void Remove(int id);

        IEnumerable<Product> GetProducts();

        Product FindById(int id);
    }
}
