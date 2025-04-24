using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    class Speler
    {
        // Instantievariabelen
        private string _naam;
        private int _gezondheid; // 1 - 100
        private int _positieX; // 1 - 500
        private int _positieY; // 1 - 500
        private bool _isLevend;

      
        // Propertie
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Gezondheid
        {
            get { return _gezondheid; }
            set { _gezondheid = value; }
        }
        public int PositieX
        {
            get { return _positieX; }
            set { _positieX = value; }
        }
        public int PositieY
        {
            get { return _positieY; }
            set { _positieY = value; }
        }
        public bool IsLevend
        {
            get { return _isLevend; }
            set { _isLevend = value; }
        }


        // Constructor

        // Instantievariablen initialiseren met default waarde 
        public Speler()
        {
            _naam = "Naamloos" ;
            _gezondheid = 100 ; 
            _positieX = 0 ;
            _positieY = 0 ;
            _isLevend = true;
        }

        // Alle properties meegeven als parameter
        public Speler(string naam, int gezondheid, int positieX, int positieY, bool isLevend)
        {
            _naam = naam;
            _gezondheid = 100;
            _positieX = positieX;
            _positieY = positieY;
            _isLevend = true;
        }


        // Methoden

        // X en Y positie wijzigen (enkel positief, optellen)
        public void Verplaats(int waardeX, int waardeY)
        {
            _positieX += waardeX;
            _positieY += waardeY;
        }

        // Gezondheid beschadigen (Kan niet negatief worden, anders ISlevend false)
        public void OntvangSchade(int schade)
        {
            _gezondheid -= schade;

            if (_gezondheid <= 0)
            {
                _gezondheid = 0;
                _isLevend = false;
            }
        }
        // Gezondheid herstelen (Kan niet groter dan 100 worden)
        public void Genees(int herstel)
        {
            if ((_gezondheid + herstel) >= 100)
            {
                _gezondheid = 100;
                return;
            }
            else
            {
                _gezondheid += herstel;
                return;
            }
            
        }

    }
}

