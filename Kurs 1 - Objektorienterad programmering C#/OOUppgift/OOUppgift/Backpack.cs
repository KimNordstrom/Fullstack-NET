﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOUppgift
{
    class Backpack
    {
        public string[] Snacks { get; set; }
        public string Brand { get; }
        public Backpack(string brand = "Fjallraven")
        {
            string[] snacks = new string[]{ "Cake", "Sandwich", "Chips"};
            Snacks = snacks;
            Brand = brand;
        }
    }
}
