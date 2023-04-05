using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moment2
{
    internal class Fordon
    {
        
        public Fordon() { }

        private static int ID = 0;// Klassen har också en statisk variabel ID som håller reda på antalet skapade fordon

        public int id = 0;// Klassen har en instansvariabel id som tilldelas ett unikt värde för varje fordon
        public Fordon(string _make, string _model,string _color, int _year)// Klassen har fyra egenskaper: Make, Model, Color och Year
        {
            Make = _make;
            Model = _model;
            Color = _color;
            Year = _year;
            id = ++ID;
        }
        public Fordon(string _make, string _model, int _year)// Klassen har konstruktorer som tar olika parametrar för att skapa ett fordon
        {
            Make = _make;
            Model = _model;
            Year = _year;
            id = ++ID;
        }
        
        public Fordon(string make, string model, string color)// Klassen har konstruktorer som tar olika parametrar för att skapa ett fordon
        {
            Make = make;
            Model = model;
            Color = color;
            id = ++ID;
        }

        public string Make { set; get; }
        public string Model { set; get; }
        public string Color { set; get; }
        public int Year { set; get; }

        public int getID()// Klassen har en metod getID som returnerar id-värdet för ett fordon
        {
            return id;
        }
    }
}
