﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaWebDatabase db = new TiendaWebDatabase();
            Categories category = new Categories();

            category.Name = "Ferreteria";
            db.Categories.Add(category);


            Products producto = new Products();
            producto.Name = "Martillo";
            producto.Price = 30;
            producto.Categories.Add(category);
            //db.Products.Add(producto);
            category.Products.Add(producto);
            db.SaveChanges();
        }
    }
}
