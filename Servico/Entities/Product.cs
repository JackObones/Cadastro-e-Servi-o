using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Entities
{
    class Product
    {
        public String ProdName { get; set; }
        public double Price { get; set; }

        public Product(string prodname, double price)
        {
            ProdName = prodname;
            Price = price;
        }
    }
}

