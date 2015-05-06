using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class HelpedStudent : Entity
    {
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<TutoringSession> session { get; set; }        
    }
}
