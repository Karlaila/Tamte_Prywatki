using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class ramka
    {
        public string data;
        public string poziom;
        public string nrPodejscia;
        public enum typRamki {czas, start, koniec, popr};
        public string lp;
        public string dane;
        private string pPlik;
        public StreamWriter file;

        public ramka()
        {
            // nawiązanie połączenia z 
            data = DateTime.Today.ToString("d");
            pPlik = status.pDane + status.nUzytk + ".txt";
            try
            {
                file = new StreamWriter(pPlik, true);
            }
            catch (Exception ex)
            {
                File.Create(pPlik);
                file = new StreamWriter(pPlik, true);
            }
        }

        //ramka: data poziom podejście czas trwania(s) poprawność(%) średni czas odpowiedzi(ds)
        public void zapis(int poziom, int nrPodejscia, int czas, double popr, double sczas)
        {
            dane = data + " " + poziom.ToString() + " " + nrPodejscia.ToString() +" " + czas.ToString() + " " + popr.ToString() + " " + sczas.ToString();
            file.WriteLine(dane);
        }

        // Do zrobienia odczytywanie danej z pliku

        // Stąd połączenie z Pythonem? Wcześniej trzeba zamknąć połączenie z plikiem

    }
}
