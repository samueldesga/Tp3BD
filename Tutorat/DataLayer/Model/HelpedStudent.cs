using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    class HelpedStudent : Entity
    {
        string EmailAdress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        public ICollection<TutoringSession> session { get; set; }        
    }
}
