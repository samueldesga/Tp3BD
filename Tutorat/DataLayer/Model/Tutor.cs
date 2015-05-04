using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    class Tutor : Entity
    {
        string prenom{get; set;}
        string lastName { get; set; }
        string adresseCourriel { get; set; }
        public ICollection<TutoringSession> session { get; set; }

   


    }
}
