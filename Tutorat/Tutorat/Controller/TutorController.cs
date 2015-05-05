using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Model;
using DataLayer;
namespace Tutorat.Controller
{
   public class TutorController 
    {
       IEntityRepository<Tutor> tutorRepository;
       TutorController(IEntityRepository<Tutor> _tutorRepository)
       {
           tutorRepository = _tutorRepository;
       }

       public void ListAll()
       {

       }

    }
}
