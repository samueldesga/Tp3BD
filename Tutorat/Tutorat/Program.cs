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

            Console.WriteLine("**********************************");
            Console.WriteLine("     ListAll TutorController      ");
            Console.WriteLine("**********************************");
            Console.WriteLine("");
            tutorController.ListAll();//fonctionnel

            Console.WriteLine(""); 
            Console.WriteLine("**********************************");
            Console.WriteLine("  ListAll HelpedStudentController ");
            Console.WriteLine("**********************************");
            Console.WriteLine("");
            helpedStudentController.ListAll();//fonctionnel

            Console.WriteLine(""); 
            Console.WriteLine("**********************************");
            Console.WriteLine(" ListAll TutoringSessionController");
            Console.WriteLine("**********************************");
            Console.WriteLine("");
            tutoringSessionController.ListAll();//fonctionnel

            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("  listAllWithWorkingHoursTotal TutorController");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            tutorController.listAllWithWorkingHoursTotal();//fonctionnel

            Console.WriteLine(""); 
            Console.WriteLine("**********************************************");
            Console.WriteLine("  ListWhenNextTutoringSession TutorController ");
            Console.WriteLine("**********************************************");
            Console.WriteLine(""); 
            tutorController.ListWhenNextTutoringSession();//fonctionnel

            Console.WriteLine(""); 
            Console.WriteLine("**********************************************");
            Console.WriteLine("ListWhenWithoutTutoringSession TutorController");
            Console.WriteLine("**********************************************");
            Console.WriteLine(""); 
            tutorController.ListWhenWithoutTutoringSession(new DateTime(2015, 6, 2));//fonctionnel

            Console.WriteLine(""); 
            Console.WriteLine("******************************************************");
            Console.WriteLine("ListWhenWithoutTutoringSession HelpedStudentController");
            Console.WriteLine("******************************************************");
            Console.WriteLine(""); 
            helpedStudentController.ListWhenWithoutTutoringSession();//fonctionnel


            Console.ReadKey();
        }
    }
}
