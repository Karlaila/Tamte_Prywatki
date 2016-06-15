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
        private StreamReader file;

        public ramka()
        {
            // nawiązanie połączenia z 
            data = DateTime.Today.ToString("d");
            pPlik = status.pDane + status.nUzytk;
            try
            {
                file = new StreamReader(pPlik, true);
            }
            catch (Exception ex)
            {
                File.Create(pPlik);
            }
        }

    }
}
