using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    class TutoringSession : Entity
    {
        DateTime DateTimeSession { get; set; }
        HelpedStudent Helped { get; set; }
        int HelpedId { get; set; }
        int LenghtSession { get; set; }
        Tutor Tutor { get; set; }
        int TutorId { get; set; }
    }
}
