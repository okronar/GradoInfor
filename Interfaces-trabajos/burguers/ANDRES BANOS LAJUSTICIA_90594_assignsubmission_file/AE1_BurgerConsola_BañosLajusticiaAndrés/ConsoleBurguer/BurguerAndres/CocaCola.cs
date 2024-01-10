﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurguerAndres
{
    internal class CocaCola : Bebida {
        private double price = 2.30;
        private String name = "Coca-Cola";
        private int unidades;

        public CocaCola(int num) { 
            this.unidades = num;

        }

        public override double CalculatePrice() {
            return Math.Round(price*unidades, 2);
        }

        public override double GetPricePerUnit() {
            return Math.Round(price,2);
        }

        public override int GetQuantity() {
            return unidades;
        }

        public override string GetName() {
            return name;

        }

        public override string ToString() {
            String a = String.Format("{0,-15}\t{1,-15}\t{2,-15}\t{3,-15}", GetName(), GetQuantity(), GetPricePerUnit(), CalculatePrice());
            return a;
        }
    }
}
