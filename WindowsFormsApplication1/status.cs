using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class status
    {
        // stan gry
        public static bool czypauza;
        // plik z użytkownikami - nazwa
        public static string pUzytk = "dane/uzytkownicy.txt";
        public static string pDane = "dane/";
        public static string nUzytk = null;

        // poziomy
        // krok podstawowy w prawo: kp, w lewo: kl; obrót po kwadracie w prawo: op, w lewo: ol; poziomy: 1,2,3, m - z muzyką.
        public enum poziomy {nic, kp1, kp2, kp3, kpm, kl1, kl2, kl3, klm, op1, op2, op3, opm, ol1, ol2, ol3, olm};
        public static int poziom;
        public static int nrPodejscia;

        // plik użytkownika
        // dane

        // okna
        public static oMenu menu;
        public static oWybor wybor;
        public static oKurs kurs;
        public static oInformacje info;
        public static oWyniki wyniki;
        public static oPauza pauza;
        public static oPomoc pomoc;
        public static ramka ramka;

        //teksty
        public static String[] oPoziomu = new String[17]; // dodać opisy!


        //filmy - źródła
        public static String[] zFilmu1 = { "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi" }; // dodać filmy!
        public static String[] zFilmu2 = { "filmy/wP1start.avi", "filmy/wP1krokipierwsze.avi", "filmy/wP1kroki.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi", "filmy/wP1start.avi" }; // dodać filmy!
        
    }
}
