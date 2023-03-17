using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class CalculatorLogic
    {
        public int Budget { get; set; } = 0;
        public int CountOfCities { get; set; } = 0;
        public bool IsEuropean { get; set; } = true;
        private static List<City> _cities = InitCities();
        public City? StartCity { get; set; }
        public List<City> CitiesForTravel { get; set; } = new List<City>();

        //Инициализирует список представленных в тз городов
        public static List<City> InitCities()
        {
            List<City> list = new List<City>();
            var Berlin = new City("Берлин", 175, 399);
            var Praga = new City("Прага", 270, 300);
            var Paris = new City("Париж", 220, 350);
            var Riga = new City("Рига", 170, 250);
            var London = new City("Лондон", 270, 390, false);
            var Vatican = new City("Ватикан", 350, 500);
            var Palermo = new City("Палермо", 150, 230);
            var Varshava = new City("Варшава", 190, 300);
            var Kishinev = new City("Кишинёв", 110, 215, false);
            var Madrid = new City("Мадрид", 190, 260);
            var Budapest = new City("Будапешт", 230, 269);

            Madrid.TransitCity = Paris;
            Kishinev.TransitCity = Budapest;
            London.TransitCity = Paris;
            Riga.TransitCity = Varshava;
            Vatican.Surcharge = 0.50;
            Berlin.Surcharge = 0.13;

            list.Add(Berlin);
            list.Add(Praga);
            list.Add(Paris);
            list.Add(Riga);
            list.Add(London);
            list.Add(Vatican);
            list.Add(Palermo);
            list.Add(Varshava);
            list.Add(Kishinev);
            list.Add(Madrid);
            list.Add(Budapest);

            return list;
        }

        public static City? GetCity(string city)
        {
            return _cities.Find(c => c.Name.Equals(city));
        }

        public static double CalculateTravelCost(in bool isEuropean, in City startCity, in List<City> citiesToTravel)
        {
            var cost = 0.0;
            var couldRecountRiga = true;

            if (citiesToTravel.Count > 1)
                if (citiesToTravel.FindIndex(c => c.Name == "Палермо") != -1)
                    if (citiesToTravel.FindIndex(c => c.Name == "Палермо") + 1 == citiesToTravel.FindIndex(c => c.Name == "Рига"))
                    {
                        //цены на транзит варшавы и берлина
                        cost = 190 + 175;
                        couldRecountRiga = false;
                    }

            foreach (var city in citiesToTravel)
            {
                double tempCost = city.TravelPrice;

                //Нужно ли проходить через транзитный город
                if (city.TransitCity != null)
                    if (city.Name.Equals("Рига") && couldRecountRiga)
                        tempCost += city.TransitCity.TransitCost;
                if (city.Name.Equals("Рига") == false && city.TransitCity != null)
                    tempCost += city.TransitCity.TransitCost;


                //Есть ли доп налоги
                if (city.Surcharge != null)
                    tempCost += tempCost * (double)city.Surcharge;

                //особое условие для палермо 
                if (city.Name.Equals("Палермо") && startCity.Name.Equals("Лондон"))
                    tempCost += tempCost * 0.07;
                else if (city.Name.Equals("Палермо") && startCity.Name.Equals("Кишинёв"))
                    tempCost += tempCost * 0.11;

                //Надбавка не европейцам
                if (!isEuropean && city.IsEuropeanCity)
                    tempCost += tempCost * 0.04;

                cost += tempCost;
            }

            return cost;
        }
    }
}