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
        public Key(object note, string accidentall, object octave)
        {
            this.Note = note.ToString();
            this.Accidental = accidentall;
            this.Octave = (int)octave;
        }

        public string Note { get; set; }
        public string Accidental { get; set; }
        public int Octave { get; set; }

        public override string ToString()
        {
            return $"{Note}{Accidental} ({Octave.ToString()})";
            
        }
    }
}
