using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogFood
{
    public partial class Form1 : Form
    {
        Dog Dog1 = new Dog();
        Dog Dog2 = new Dog();
        Dog Dog3 = new Dog();
        Dog Dog4 = new Dog();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFillDry_Click(object sender, EventArgs e)
        {
            Dog1.Name = "Rex";
            Dog1.WetFoodQty = 0;
            Dog1.DryFoodQty = 3;

            Dog2.Name = "Mimi";
            Dog2.WetFoodQty = 0.25M;
            Dog2.DryFoodQty = 0;

            Dog3.Name = "Fido";
            Dog3.WetFoodQty = 0.5M;
            Dog3.DryFoodQty = 0.5M;

            Dog4.Name = "Rex";
            Dog4.WetFoodQty = 0.25M;
            Dog4.DryFoodQty = 0.5M;

        }

        private void btnPerDay_Click(object sender, EventArgs e)
        {
            decimal FinalDay = Dog1.DayTotal() + Dog2.DayTotal() + Dog3.DayTotal() + Dog4.DayTotal();
            lblDaily.Text = FinalDay.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            decimal FinalWeek = Dog1.WeekTotal() + Dog2.WeekTotal() + Dog3.WeekTotal() + Dog4.WeekTotal();
            lblDaily.Text = FinalWeek.ToString();
        }

        private void btnPerWeek_Click(object sender, EventArgs e)
        {
            lblDaily.Text = String.Empty;
        }
    }
}
