using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoKeyboard
{
    public enum Accidental
    {
        [Description("#")]
        Sharp,

        [Description("b")]
        Flat,

        [Description("")]
        NoSign
    }
}
