using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.ViewModel
{
    class WorkingHoursTutorListVM
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public int Id { get; set; }
        public int totalHeures { get; set; }
        public override string ToString()
        {
            string tutorInformation = LastName + ", " + FirstName + "    Email: " + EmailAdress + 
                "    Heures: " + totalHeures;
            return tutorInformation;
        }
    }
}
