using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.ViewModel
{
    class TutoringSessionListVM
    {
        public DateTime DateTimeSession { get; set; }

        public string helpFirstName { get; set; }

        public string helpLastName { get; set; }
        public int Id { get; set; }
        public int lenghtSession { get; set; }
        public string tutorFirstName { get; set; }
        public string tutorLastName { get; set; }

        public override string ToString()
        {
            string tutoringSessionInformation = "Date: " + DateTimeSession + ", Helped: " + helpFirstName + 
                " " + helpLastName + "   Tutor:" + tutorFirstName + " " + tutorLastName + "   lenght:" + 
                lenghtSession;
            return tutoringSessionInformation;
        }
    }
}
