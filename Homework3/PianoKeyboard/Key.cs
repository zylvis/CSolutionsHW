using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PianoKeyboard;
using PianoKeyboard.Utility;
using System.Reflection;
using PianoKeyboard.Extenstions;

namespace PianoKeyboard
{
    public struct Key: IComparable<Key>
    {
        public Key(Note note, Accidental accidental, Octave octave)
        {
            this.Note = note.ToString();
            this.Accidental = accidental.GetEnumAttribute();
            this.Octave = (int)octave;
        }

        public string? Note { get; set; }
        public string Accidental { get; set; }
        public int Octave { get; set; }

        public override string ToString()
        {
            return $"{Note}{Accidental} ({Octave})";
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
                case ENotes.ASharpBflat:
                    return true;

                case ENotes.BCflat:
                    return true;

                case ENotes.BSharpC:
                    return true;

                case ENotes.CSharpDflat:
                    return true;

                case ENotes.DSharpEb:
                    return true;

                case ENotes.EFflat:
                    return true;

                case ENotes.ESharpF:
                    return true;

                case ENotes.FSharpGflat:
                    return true;

                case ENotes.GSharpAflat:
                    return true;

                default:
                    return false;
            }
        }

        public int CompareTo(Key other)
        {
            if (Note == other.Note && Accidental == other.Accidental && Octave == other.Octave)
            {
                return 1;
            }
            return 0;
        }
    }
}
