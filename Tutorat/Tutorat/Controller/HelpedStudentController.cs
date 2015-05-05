using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.Controller
{
    class HelpedStudentController
    {
        IEntityRepository<HelpedStudent> helpedStudentRepository;
        HelpedStudentController(IEntityRepository<HelpedStudent> _helpedStudentRepository)
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
            var helpedView = new HelpedListView(tutorVMList);
            helpedView.Display();

        }
    }
}
