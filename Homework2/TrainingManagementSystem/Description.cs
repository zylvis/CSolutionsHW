using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    abstract class Description
    {
        public string DescriptionText { get; set; }
       
        public Description(string descriptionText)
        {
            DescriptionText = descriptionText;
        }
    }
}
