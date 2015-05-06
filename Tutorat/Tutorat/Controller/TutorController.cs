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
 public  class TutorController 
    {
       IEntityRepository<Tutor> tutorRepository;
     public  TutorController(IEntityRepository<Tutor> _tutorRepository)
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
           new TutorListView(tutorVMList).Display();           
       }

     //Query 2
       public void ListWhenNextTutoringSession()
       {
           var tutors = tutorRepository.GetAll().ToList();

           var tutorVMList = new List<TutorListVM>();

           foreach (Tutor t in tutors)
           {
               foreach(TutoringSession s in t.session)
               {
                   if(s.DateTimeSession > DateTime.Now)
                   {
                       tutorVMList.Add(new TutorListVM()
                       {
                           EmailAdress = t.EmailAdress,
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Id = t.Id
                       });
                   }
                   
               }
               
           }
           new TutorListView(tutorVMList).Display();
       }

    }
}
