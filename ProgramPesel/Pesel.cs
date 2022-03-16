using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPesel
{
    class Pesel
    {
        private string numerPesel;
        public string Plec 
        { 
            get 
            {
                return numerPesel[9].ToString();
            } 
        
        }
        public string PlecOpis
        {
            get
            {
                int plec = int.Parse(numerPesel[9].ToString());
                if (plec % 2 == 0)
                {
                    return "Kobieta";
                }
                else
                    return "Mężczyzna";
            }
        }
        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
            Walidacja();

        }

        private void Walidacja()
        {
            WalidacjaPoprawnoscDlugosci();
            WalidacjaPoprawnosciZnakow();
            //WalidacjaPoprawnosciMiesiaca();
            //WalidacjaPoprawnosciDnia();
            //WalidacjaPoprawnosciCyfryKontrolnej();
        }

        private void WalidacjaPoprawnosciCyfryKontrolnej()
        {
            throw new NotImplementedException();
        }

        private void WalidacjaPoprawnosciDnia()
        {
            throw new NotImplementedException();
        }

        private void WalidacjaPoprawnosciMiesiaca()
        {
            throw new NotImplementedException();
        }

        private void WalidacjaPoprawnosciZnakow()
        {
            for(int i = 0; i<11; i++)
            {
                if (numerPesel[i] < '0' && numerPesel[i] > '9')
                    throw new Exception("W numerze PESEL występują niepoprawne znaki");
            }
        }

        private void WalidacjaPoprawnoscDlugosci()
        {
            int dlugosc = numerPesel.Length;
            if(dlugosc != 11)
                throw new Exception("Zła długość numeru PESEL");
            
        }
        private int Parse(string liczbaStr)
        {
            int wynik = 0;
            int pozycja = 1;
            for(int i =liczbaStr.Length-1; i<= 0; i++)
            {
                wynik = ((int)liczbaStr[i] - 48) * pozycja + wynik;
                pozycja *= 10;
            }

            return wynik;

        }
    }
}
