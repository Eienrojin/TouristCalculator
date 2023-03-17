using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CalculatorLogic CalculatorLogic = new CalculatorLogic();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeleteButton.Enabled = SafeDeleteCheckBox.Checked;
            CalculatorLogic.IsEuropean = IsEuropeanCheckBox.Checked;
        }

        private void AddToCityList_Click(object sender, EventArgs e)
        {
            var currentCity = GetCityFromComboBox();
            var travelString = "";

            if (currentCity != null
                && CalculatorLogic.CitiesForTravel.Count <= 2
                && !CalculatorLogic.CitiesForTravel.Contains(currentCity))
            {
                CalculatorLogic.CitiesForTravel.Add(currentCity);
            }
            else
                return;

            foreach (var city in CalculatorLogic.CitiesForTravel)
                travelString += city.Name + " ";

            TravelLabel.Text = "Маршрут - " + travelString;
        }

        private City? GetCityFromComboBox() =>
            CalculatorLogic.GetCity(CitiesComboBox.Text);

        private void checkBox2_CheckedChanged(object sender, EventArgs e) =>
            DeleteButton.Enabled = SafeDeleteCheckBox.Checked;

        private void StartCityButton_Click(object sender, EventArgs e)
        {
            City? startCity = GetCityFromComboBox();

            if (startCity != null)
            {
                CalculatorLogic.StartCity = startCity;
                StartCityLabel.Text = "Город отправления - " + startCity.Name;
            }
            else
            {
                MessageBox.Show("Не выбран город");
                StartCityLabel.Text = "Город отправления - не выбран";
            }
        }

        private void IsEuropeanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculatorLogic.IsEuropean = IsEuropeanCheckBox.Checked;
        }

        private void CalculateTransitButton_Click(object sender, EventArgs e)
        {
            double cost = 0.0;
            bool safeBudget = true;

            try
            {
                CalculatorLogic.Budget = int.Parse(BudgetTextBox.Text);
            }
            catch (Exception)
            {
                safeBudget = false;
            }

            if (safeBudget && CalculatorLogic.StartCity != null && CalculatorLogic.CitiesForTravel.Count != 0 && CalculatorLogic.Budget != 0)
            {
                cost = CalculatorLogic.CalculateTravelCost(CalculatorLogic.IsEuropean, CalculatorLogic.StartCity, CalculatorLogic.CitiesForTravel);

                try
                {
                    if (cost < Double.Parse(BudgetTextBox.Text))
                        MessageBox.Show(cost.ToString() + ". Вы проходите по бюджету");
                    else
                        MessageBox.Show(cost.ToString() + ". Вы не проходите по бюджету");
                }
                catch (Exception)
                {
                    MessageBox.Show("Проверьте правильность ввода бюджета");
                }
            }
            else
                MessageBox.Show("Поля не заполнены, либо неправильны");
        }

        private void BudgetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CalculatorLogic = new CalculatorLogic();
            IsEuropeanCheckBox.Checked = false;
            BudgetTextBox.Text = "";
            TravelLabel.Text = "Маршрут -";
            StartCityLabel.Text = "Город отправления -";
        }
    }
}
