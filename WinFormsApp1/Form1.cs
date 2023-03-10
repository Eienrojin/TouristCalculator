using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly CalculatorLogic CalculatorLogic = new CalculatorLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToCityList_Click(object sender, EventArgs e)
        {
            var currentCity = GetCityFromComboBox();
            var travelString = "";

            if (currentCity != null && CalculatorLogic.CitiesForTravel.Count <= 2)
                CalculatorLogic.CitiesForTravel.Add(currentCity);
            else
                return;

            foreach (var city in CalculatorLogic.CitiesForTravel)
                travelString += city.Name + " ";

            TravelLabel.Text = "Маршрут - " + travelString;
        }

        private City? GetCityFromComboBox() =>
            CalculatorLogic.GetCity(CitiesComboBox.Text);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
