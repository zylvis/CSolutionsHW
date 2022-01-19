using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoKeyboard
{

    public enum Accidental
    {
        [Display(Name = "#")]
        Sharp,

        [Display(Name = "b")]
        Flat,

        [Display(Name = "")]
        NoSign
    }
}
