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
        public string pPlik;

        public ramka()
        {
            data = DateTime.Today.ToString("d");
            try
            {
                pPlik = status.pDane + status.nUzytk;
                StreamReader file = new StreamReader(status.pUzytk, true);
                while ((U = file.ReadLine()) != null)
                {
                    Uzytk.Add(U);
                    lUzytk++;
                    cBwybierz.Items.Add(U);
                }
                file.Close();*/
            }
            catch (Exception ex)
            {
                //File.Create(status.pUzytk);
            }
        }

    }
}
