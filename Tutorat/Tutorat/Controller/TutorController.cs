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
        public TutorController(IEntityRepository<Tutor> _tutorRepository)
        {
            tutorRepository = _tutorRepository;
        }

        public void ListAll()
        {
            var tutors = tutorRepository.GetAll().ToList();

            var tutorVMList = new List<TutorListVM>();

            foreach (Tutor t in tutors)
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
        //Query 1
        public void listAllWithWorkingHoursTotal()
        {
            var tutors = tutorRepository.GetAll().ToList();
            var tutorVMListWorking = new List<WorkingHoursTutorListVM>();
            foreach (Tutor t in tutors)
            {
                int totalheures = 0;

                foreach (TutoringSession s in t.session)
                {
                    totalheures = totalheures + s.LenghtSession;
                }
                tutorVMListWorking.Add(new WorkingHoursTutorListVM()
                {

                    EmailAdress = t.EmailAdress,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Id = t.Id,
                    totalHeures = totalheures
                });
            }

            var TutorControllerViewHour = new WorkingHoursTutorListView(tutorVMListWorking);
            TutorControllerViewHour.Display();
        }

        //Query 2
        public void ListWhenNextTutoringSession()
        {
            var tutors = tutorRepository.GetAll().ToList();

            var tutorVMList = new List<ListAllWitnNextTutoringSessionVM>();

            foreach (Tutor t in tutors)
            {
                foreach (TutoringSession s in t.session)
                {
                    if (s.DateTimeSession > DateTime.Now)
                    {
                        tutorVMList.Add(new ListAllWitnNextTutoringSessionVM()
                        {
                            DateTimeSession = s.DateTimeSession,
                            LenghtSession = s.LenghtSession,
                            HelpedFirstName = s.Helped.FirstName,
                            HelpedLastName = s.Helped.LastName,
                            TutorFirstName = t.FirstName,
                            TutorLastName = t.LastName
                        });
                    }

                }

            }
            tutorVMList.OrderBy(Tutor => Tutor.TutorFirstName).ThenBy(TutoringSession => TutoringSession.DateTimeSession);
            new ListAllWithNextTutoringSessionView(tutorVMList).Display();
        }

        //Query 4
        public void ListWhenWithoutTutoringSession(DateTime _sessionDate)
        {
            var tutors = tutorRepository.GetAll().ToList();

            var tutorVMList = new List<TutorListVM>();
            bool sessionOnDate = false;
            foreach (Tutor t in tutors)
            {
                sessionOnDate = false;
                foreach (TutoringSession s in t.session)
                {
                    if (s.DateTimeSession.Date == _sessionDate.Date)
                    {
                        sessionOnDate = true;
                    }

                }
                if (!sessionOnDate)
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
            new TutorListView(tutorVMList).Display();
        }

    }
}
