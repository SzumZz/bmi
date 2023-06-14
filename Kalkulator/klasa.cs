using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class klasa
    {
        private string plec2;
        private double wiek;
        private double waga;
        private double wzrost;
        private string aktywnosc;
        private double PPM;
        private double BMI;
        private double CPM;
        public string Plec2
        {
            get { return plec2; }
            set { plec2 = value; }
        }
        public double Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }
        public double Waga
        {
            get { return waga; }
            set { waga = value; }
        }
        public double Wzrost
        {
            get { return wzrost; }
            set { wzrost = value; }
        }
        public string Aktywnosc
        {
            get { return aktywnosc; }
            set { aktywnosc = value; }
        }
        public double Ppm
        {
            get { return PPM; }
            set { PPM = value; }
        }
        public double Bmi
        {
            get { return BMI; }
            set { BMI = value; }
        }
        public double Cpm
        {
            get { return CPM; }
            set { CPM = value; }
        }
        public klasa()
        {
            plec2 = "";
            wiek = 0;
            waga = 0;
            wzrost = 0;
            aktywnosc = "";
            PPM = 0;
            BMI = 0;
            CPM = 0;
        }
        public klasa(string plec2, double wiek, double waga, double wzrost, string aktywnosc, double PPM, double BMI, double CPM)
        {
            this.Plec2 = plec2;
            this.Wiek = wiek;
            this.Waga = waga;
            this.Wzrost = wzrost;
            this.Aktywnosc = aktywnosc;
            this.Ppm = PPM;
            this.Bmi = BMI;
            this.Cpm = CPM;
        }
        public string wyswietl()
        {
            return ("Płeć: " + plec2 + "\nWiek: " + wiek + "\nWaga: " + waga + "\nWzrost: " + wzrost + "\nAktywność: " + aktywnosc + "\nPPM: " + PPM + "\nBMI: " + BMI + "\nCPM: " + CPM);
        }
    }
}
