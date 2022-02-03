using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking
{
    public class Logger
    {
        public string FileName { get; set; }
        public Logger(string fileName)
        {
            FileName = fileName;
        }

        public void Track(object obj)
        {
            
        }

    }
}
