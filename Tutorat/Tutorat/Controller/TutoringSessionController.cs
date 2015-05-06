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
    public class TutoringSessionController
    {
        IEntityRepository<TutoringSession> tutoringRepository;
        public TutoringSessionController(IEntityRepository<TutoringSession> _TutoringRepository)
        {

            tutoringRepository = _TutoringRepository;
        }
    public void ListAll()
        {
            var tutoringSession = tutoringRepository.GetAll().ToList();

            var tutorVMList = new List<TutoringSessionListVM>();

            foreach (TutoringSession t in tutoringSession)
            {
                tutorVMList.Add(new TutoringSessionListVM()
                {
                    helpFirstName = t.Helped.FirstName,
                    helpLastName = t.Helped.LastName,
                    tutorFirstName = t.Tutor.FirstName,
                    tutorLastName = t.Tutor.LastName,
                    DateTimeSession = t.DateTimeSession,
                    lenghtSession = t.LenghtSession,
                    Id = t.Id
                });
            }

            var sessionListView = new SessionListView(tutorVMList);
            sessionListView.Display();

        }
    }
}
