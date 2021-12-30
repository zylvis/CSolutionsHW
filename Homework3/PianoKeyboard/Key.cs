using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PianoKeyboard;

namespace PianoKeyboard
{
    public struct Key
    {
        public Key(Note note, string accidental, int octave)
        {
            Note = note;
            Accidental = accidental;
            Octave = octave;

        }

        public string Note { get; set; }
        public string Accidental { get; set; }
        public int Octave { get; set; }


        public override string ToString()
        {


            return base.ToString();
        }


    }
}
