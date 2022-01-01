using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PianoKeyboard;
using PianoKeyboard.Utility;

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

        public override bool Equals(object obj)
        {
            Key k = (Key)obj;
            string enharmonic = Note + Accidental + k.Note + k.Accidental;

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else if (Note == k.Note && Accidental == k.Accidental)
            {

                return true;
            }

            switch (enharmonic)
            {
                case SD.ASharpBflat:

                    return true;

                case SD.BCflat:

                    return true;

                case SD.BSharpC:

                    return true;

                case SD.CSharpDflat:

                    return true;
                case SD.DSharpEb:

                    return true;
                case SD.EFflat:

                    return true;

                case SD.ESharpF:

                    return true;
                case SD.FSharpGflat:

                    return true;

                case SD.GSharpAflat:

                    return true;

                default:
                    return false;
            }






        }
    }
}
