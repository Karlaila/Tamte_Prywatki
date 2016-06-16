using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    public class ButtonReader
    {
        private const int ARROWS_BYTE = 5;
        private const int XBOX_BYTE = 6;
        private const int MENU_BYTE = 6;

        public enum PadButton
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

        public List<PadButton> readButtons(byte[] readData)
        {
            BitArray buttonsBits = new BitArray(readData);
            List<PadButton> pressedButtons = new List<PadButton>();
            int offset = ARROWS_BYTE * 8;
            for (int i = (int)PadButton.LEFT; i <= (int)PadButton.START; i++)
            {
                if (buttonsBits.Get(offset + i) == true)
                {
                    PadButton pressedButton = (PadButton)i;
                    pressedButtons.Add(pressedButton);
                }
            }
            return pressedButtons;
        }
    }
}
