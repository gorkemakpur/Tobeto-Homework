﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
