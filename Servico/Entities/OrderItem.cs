using System;
using System.Globalization;
using Servico.Entities;
using System.Collections.Generic;
using System.Text;

namespace Servico.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Product.ProdName
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", SubTotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

