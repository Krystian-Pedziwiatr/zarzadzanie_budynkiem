﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_budynkiem
{
    internal class Automatyzacja : Budynek
    {
        private Budynek budynek;
        public Automatyzacja(Budynek budynek)
        {
            this.budynek = new Budynek();
        }
    }
}