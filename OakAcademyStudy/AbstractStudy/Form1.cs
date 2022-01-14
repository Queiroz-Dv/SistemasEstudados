using System;
using System.Windows.Forms;

namespace AbstractStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Vehicle
        {
            public abstract double GetFuelAmount();
        }
        class Bus : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 600;
            }
        }
        class Truck : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 900;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc;
            vc = new Bus();
            double busfuel = vc.GetFuelAmount();
            text += "Bus Fuel Amount is: " + busfuel.ToString() + Environment.NewLine;
            vc = new Truck();
            double truckFuel = vc.GetFuelAmount();
            text += "Truck Fuel Amount is: " + truckFuel.ToString() + Environment.NewLine;
            textBox1.Text = text;
        }
    }
}
