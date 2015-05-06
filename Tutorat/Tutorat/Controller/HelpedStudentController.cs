using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.View;
using Tutorat.ViewModel;

namespace Tutorat.Controller
{
    public class HelpedStudentController
    {
        IEntityRepository<HelpedStudent> helpedStudentRepository;
        public HelpedStudentController(IEntityRepository<HelpedStudent> _helpedStudentRepository)
        {
            helpedStudentRepository = _helpedStudentRepository;
        }

        public void ListAll()
        {
            var helped = helpedStudentRepository.GetAll().ToList();

            var helpedVMList = new List<HelpedListVM>();

            foreach (HelpedStudent t in helped)
            {
                helpedVMList.Add(new HelpedListVM()
                {
                    EmailAdress = t.EmailAdress,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Id = t.Id
                });
            }
            new HelpedListView(helpedVMList).Display();

        }
        //Query 3
        public void ListWhenWithoutTutoringSession()
        {
            var student = helpedStudentRepository.GetAll().ToList<HelpedStudent>();

            var studentVMList = new List<HelpedListVM>();

            foreach (HelpedStudent hs in student)
            {
                if (hs.session.Count == 0)
                {

                    studentVMList.Add(new HelpedListVM()

                    {
                        FirstName = hs.FirstName,
                        LastName = hs.LastName,
                        Id = hs.Id,
                        EmailAdress = hs.EmailAdress
                    }
                        );
                }
            }
            new HelpedListView(studentVMList).Display();
        }
    }
}


