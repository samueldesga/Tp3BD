using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.ViewModel
{
    class ListAllWitnNextTutoringSessionVM
    {

        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }
        public string HelpedFirstName { get; set; }
        public string HelpedLastName { get; set; }
        public DateTime DateTimeSession { get; set; }
        public int LenghtSession { get; set; }

        public override string ToString()
        {
            string tutorInformation = "Date: " + DateTimeSession + ", Helped: " + HelpedFirstName +
                ", " + HelpedLastName + "   Tutor:" + TutorFirstName + ", " + TutorLastName + "   lenght:" +
                LenghtSession + "h"; 
            return tutorInformation;
        }
    }
}
