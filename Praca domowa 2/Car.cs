using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObiekt002
{
    class Car
    {
        public string marka;
        public int rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;
        private static int iloscSamochodow = 0;

        public double obliczSpalanie(double dlugoscTrasy)
        {
            double spalanie;
            return spalanie = (this.srednieSpalanie * dlugoscTrasy) / 100;
        }

        public double obliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztPrzejazdu;
            return kosztPrzejazdu = obliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

    }
}