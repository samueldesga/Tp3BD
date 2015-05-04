using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    class EfDataBaseHelper
    {

        private EfEntityRepository<Tutor> tutors;
        private EfEntityRepository<HelpedStudent> helpedStudent;
        private EfEntityRepository<TutoringSession> tutoringSession;

        public EfDataBaseHelper()
        {
            tutors = new EfEntityRepository<Tutor>();




        }
        public void seed()
        {
            Tutor tutor1 = new Tutor()
            {
               
            };
            tutors.add(tutor1);
        }

        
    }
}
