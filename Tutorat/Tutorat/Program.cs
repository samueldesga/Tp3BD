using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EfEntityFramework;
using Tutorat.Controller;
using DataLayer.Model;
namespace Tutorat
{
    class Program
    {
       static void Main(string[] args)
        {

            EfDataBaseHelper database = new EfDataBaseHelper();
            
            database.seed();//peuplement des tables

            TutorController tutorController = new TutorController(new EfEntityRepository<Tutor>());
            HelpedStudentController helpedStudentController = new HelpedStudentController(new EfEntityRepository<HelpedStudent>());
            TutoringSessionController tutoringSessionController = new TutoringSessionController(new EfEntityRepository<TutoringSession>());
            //tutorController.ListAll();
            //tutorController.ListWhenNextTutoringSession();
            tutorController.listAllWithWorkingHoursTotal();
            Console.ReadKey();
       }
    }
}
