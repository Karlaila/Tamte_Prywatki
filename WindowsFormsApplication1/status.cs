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
        //zrób enum Days {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
        //int x = (int)Days.Sun;
        //1 - krok podstawowy, 2 - obrót, 3 - układ
        public static int poziom1 = 0;
        //1- powtarzanie krok po kroku; 2 - powtarzanie po strzałkach; 3- bez strzałek, 4 - z muzyką
        public static int poziom2 = 0;
        //1- wolno, 3 - szybko
        public static int poziom3 = 0;
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
        public static UsbReader reader;
    }
}
