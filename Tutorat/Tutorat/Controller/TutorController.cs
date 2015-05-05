using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Model;
using DataLayer;
using Tutorat.ViewModel;
using Tutorat.View;
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
           var tutors = tutorRepository.GetAll().ToList();

           var tutorVMList = new List<TutorListVM>();

           foreach(Tutor t in tutors)
           {
               tutorVMList.Add(new TutorListVM()
               {
                   EmailAdress = t.EmailAdress,
                   FirstName = t.FirstName,
                   LastName = t.LastName,
                   Id = t.Id
               });
           }

           var tutorView = new TutorListView(tutorVMList);
           tutorView.Display();
       }

    }
}
