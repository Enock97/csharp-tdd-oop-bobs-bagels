﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Core
{
    public class Filling : Inventory
    {
        public Filling(string sku, double price, string name, string variant)
            : base(sku, price, "Filling", variant)
        {
        }
    }
}