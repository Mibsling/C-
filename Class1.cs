using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogFood
{
   public class Dog
    {
        public decimal WetPrice = 2;
        public decimal DryPrice = 1.5M;
        public decimal WetFoodQty;
        public decimal DryFoodQty;
        public string Name;

        public decimal DayTotal()
        {
            decimal DayOutput = (WetFoodQty * WetPrice) + (DryPrice * DryFoodQty);
            return DayOutput;
        }

        public decimal WeekTotal()
        {

            return DayTotal() * 7;
        }
    }
}
