﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        public DateTime DateTimeSession { get; set; }
        public virtual HelpedStudent Helped { get; set; }
        public int HelpedId { get; set; }
        public int LenghtSession { get; set; }
        public virtual Tutor Tutor { get; set; }
        public int TutorId { get; set; }
    }
}
