﻿using System;
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
        public enum pMata
        {
            UP = 6,
            DOWN = 5,
            RIGHT = 7,
            LEFT = 4,
            X = 10,
            TRIANGLE = 9,
            SQUARE = 8,
            CIRCLE = 11,
            SELECT = 12,
            START = 13
        }
        public static int poziom;
        public static int nrPodejscia;
        public static int[][] tKroki = new int[13][];
        public static int[][] sKroki = new int[13][];

        public static void init_kroki()
        {
            // dla każdego z poziomów czasy nowego kroku w decysekundach.
            tKroki[1] = new int[]{60, 110, 180, 250, 310, 390};
            tKroki[2] = new int[] { 17, 25, 50, 57, 70, 80, 100, 120, 130, 150, 162, 175, 190, 200, 210, 220, 233, 250, 260, 270, 285, 290, 305, 320 };


            // dla każdego z poziomów sekwencje kroków
            sKroki[1] = new int[] { (int)pMata.RIGHT, (int)pMata.UP, (int)pMata.CIRCLE, (int)pMata.LEFT, (int)pMata.DOWN, (int)pMata.TRIANGLE };
            sKroki[2] = sKroki[1];
            sKroki[3] = sKroki[1];
            sKroki[4] = sKroki[1];
        }

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
        
        public static UsbReader reader;
    }
}
