using System;
using System.Windows.Forms;
using CarPriceDisplay.Models;

namespace CarPriceDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            Car myCar = new Car("Toyota Camry", 1200000);
            MessageBox.Show($"車輛名稱: {myCar.GetName()}\n車輛價格: {myCar.GetPrice():C}");
        }
    }
}