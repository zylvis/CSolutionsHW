using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PianoKeyboard.Extenstions
{
    public static class Extensions
    {
        public static string? GetEnumAttribute(this Enum enumName)
        {
            return enumName.GetType()
        .GetMember(enumName.ToString())
        .First()
        .GetCustomAttribute<DisplayAttribute>()
        ?.GetName();
        }
    }
}
