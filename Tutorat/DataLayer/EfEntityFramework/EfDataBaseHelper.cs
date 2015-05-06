using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
  public  class EfDataBaseHelper
    {

        private EfEntityRepository<Tutor> tutors;
        private EfEntityRepository<HelpedStudent> helpedStudent;
        private EfEntityRepository<TutoringSession> tutoringSession;

        public EfDataBaseHelper()
        {
            tutors = new EfEntityRepository<Tutor>();

            helpedStudent = new EfEntityRepository<HelpedStudent>();

            tutoringSession = new EfEntityRepository<TutoringSession>();


        }
        public void seed()
        {

            //Création tuteur
            Tutor tutor1 = new Tutor()
            {
                Id = 1,
                LastName = "Bilodeau",
                FirstName = "Gary",
                EmailAdress = "bgary2@hotmail.com"
            };
            tutors.add(tutor1);

            Tutor tutor2 = new Tutor()
            {
                Id = 2,
                LastName = "Gagnon",
                FirstName = "Samuel",
                EmailAdress = "samPP92@hotmail.com"
            };
            tutors.add(tutor2);

            Tutor tutor3 = new Tutor()
            {
                Id = 3,
                LastName = "Gingras",
                FirstName = "Simon",
                EmailAdress = "ptitguy22@bell.net"
            };
            tutors.add(tutor3);

            Tutor tutor4 = new Tutor()
            {
                Id = 4,
                LastName = "Roy",
                FirstName = "Éric",
                EmailAdress = "eroy231@videotron.ca"
            };
            tutors.add(tutor4);

            Tutor tutor5 = new Tutor()
            {
                Id = 5,
                LastName = "Veilleux",
                FirstName = "Caroline",
                EmailAdress = "caro.koko@hotmail.com"
            };
            tutors.add(tutor5);

            Tutor tutor6 = new Tutor()
            {
                Id = 6,
                LastName = "Tremblay",
                FirstName = "Karine",
                EmailAdress = "kar.tremblay@gmail.com"
            };
            tutors.add(tutor6);

            Tutor tutor7 = new Tutor()
            {
                Id = 7,
                LastName = "Vézina",
                FirstName = "Louis",
                EmailAdress = "vl410Bd@gmail.com"
            };
            tutors.add(tutor7);

            //Création étudiants aidés
            HelpedStudent helpedStudent1 = new HelpedStudent()
            {
                Id = 1,
                LastName = "Arsenault",
                FirstName = "Marc",
                EmailAdress = "marco.arso@hotmail.com"
            };
            helpedStudent.add(helpedStudent1);

            HelpedStudent helpedStudent2 = new HelpedStudent()
            {
                Id = 2,
                LastName = "Boilard",
                FirstName = "Éric",
                EmailAdress = "eric.r.boilard2@coop.com"
            };
            helpedStudent.add(helpedStudent2);

            HelpedStudent helpedStudent3 = new HelpedStudent()
            {
                Id = 3,
                LastName = "Couture",
                FirstName = "Jean-Cristophe",
                EmailAdress = "jc.couture.wilde@hotmail.com"
            };
            helpedStudent.add(helpedStudent3);

            HelpedStudent helpedStudent4 = new HelpedStudent()
            {
                Id = 4,
                LastName = "Desrosiers",
                FirstName = "Julianne",
                EmailAdress = "galypo13@hotmail.com"
            };
            helpedStudent.add(helpedStudent4);

            HelpedStudent helpedStudent5 = new HelpedStudent()
            {
                Id = 5,
                LastName = "Grégoire-Allen",
                FirstName = "Léo",
                EmailAdress = "leoga@hotmail.com"
            };
            helpedStudent.add(helpedStudent5);

            HelpedStudent helpedStudent6 = new HelpedStudent()
            {
                Id = 6,
                LastName = "Hamel",
                FirstName = "François",
                EmailAdress = "francoishamel@gmail.com"
            };
            helpedStudent.add(helpedStudent6);

            HelpedStudent helpedStudent7 = new HelpedStudent()
            {
                Id = 7,
                LastName = "Lepage",
                FirstName = "Jérémy",
                EmailAdress = "jeremylepage@gmail.com"
            };
            helpedStudent.add(helpedStudent7);

            HelpedStudent helpedStudent8 = new HelpedStudent()
            {
                Id = 8,
                LastName = "Poitras",
                FirstName = "Nicolas",
                EmailAdress = "nicolaspoitras@gmail.com"
            };
            helpedStudent.add(helpedStudent8);

            HelpedStudent helpedStudent9 = new HelpedStudent()
            {
                Id = 9,
                LastName = "Roy-Gagnon",
                FirstName = "Samuel",
                EmailAdress = "samuelrg@gmail.com"
            };
            helpedStudent.add(helpedStudent9);

            HelpedStudent helpedStudent10 = new HelpedStudent()
            {
                Id = 10,
                LastName = "Simard",
                FirstName = "Benjamin",
                EmailAdress = "benjaminsimard@gmail.com"
            };
            helpedStudent.add(helpedStudent10);

            HelpedStudent helpedStudent11 = new HelpedStudent()
            {
                Id = 11,
                LastName = "Vachon",
                FirstName = "Samuel",
                EmailAdress = "samuelvachon@gmail.com"
            };
            helpedStudent.add(helpedStudent11);

            //creation rencontre tutorat
            TutoringSession tutoringSession1 = new TutoringSession()
            {
                Id = 1,
                DateTimeSession = new DateTime(2015, 3, 16, 13, 0, 0),
                LenghtSession = 2,
                Helped = helpedStudent5,
                HelpedId = 5,
                Tutor = tutor5,
                TutorId = 5
            };
            tutoringSession.add(tutoringSession1);

            TutoringSession tutoringSession2 = new TutoringSession()
            {
                Id = 2,
                DateTimeSession = new DateTime(2015, 3, 24, 10, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent5,
                HelpedId = 5,
                Tutor = tutor1,
                TutorId = 1
            };
            tutoringSession.add(tutoringSession2);

            TutoringSession tutoringSession3 = new TutoringSession()
            {
                Id = 3,
                DateTimeSession = new DateTime(2015, 3, 25, 13, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent2,
                HelpedId = 2,
                Tutor = tutor4,
                TutorId = 4
            };
            tutoringSession.add(tutoringSession3);

            TutoringSession tutoringSession4 = new TutoringSession()
            {
                Id = 4,
                DateTimeSession = new DateTime(2015, 4, 1, 12, 0, 0),
                LenghtSession = 2,
                Helped = helpedStudent1,
                HelpedId = 1,
                Tutor = tutor5,
                TutorId = 5
            };
            tutoringSession.add(tutoringSession4);

            TutoringSession tutoringSession5 = new TutoringSession()
            {
                Id = 5,
                DateTimeSession = new DateTime(2015, 4, 1, 13, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent2,
                HelpedId = 2,
                Tutor = tutor3,
                TutorId = 3
            };
            tutoringSession.add(tutoringSession5);

            TutoringSession tutoringSession6 = new TutoringSession()
            {
                Id = 6,
                DateTimeSession = new DateTime(2015, 4, 6, 16, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent1,
                HelpedId = 1,
                Tutor = tutor4,
                TutorId = 4
            };
            tutoringSession.add(tutoringSession6);

            TutoringSession tutoringSession7 = new TutoringSession()
            {
                Id = 7,
                DateTimeSession = new DateTime(2015, 4, 8, 10, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent6,
                HelpedId = 6,
                Tutor = tutor4,
                TutorId = 4
            };
            tutoringSession.add(tutoringSession7);

            TutoringSession tutoringSession8 = new TutoringSession()
            {
                Id = 8,
                DateTimeSession = new DateTime(2015, 4, 10, 10, 0, 0),
                LenghtSession = 2,
                Helped = helpedStudent1,
                HelpedId = 1,
                Tutor = tutor4,
                TutorId = 4
            };
            tutoringSession.add(tutoringSession8);

            TutoringSession tutoringSession9 = new TutoringSession()
            {
                Id = 9,
                DateTimeSession = new DateTime(2015, 4, 29, 12, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent9,
                HelpedId = 9,
                Tutor = tutor5,
                TutorId = 5
            };
            tutoringSession.add(tutoringSession9);

            TutoringSession tutoringSession10 = new TutoringSession()
            {
                Id = 10,
                DateTimeSession = new DateTime(2015, 5, 25, 13, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent10,
                HelpedId = 10,
                Tutor = tutor7,
                TutorId = 7
            };
            tutoringSession.add(tutoringSession10);

            TutoringSession tutoringSession11 = new TutoringSession()
            {
                Id = 11,
                DateTimeSession = new DateTime(2015, 5, 27, 12, 0, 0),
                LenghtSession = 2,
                Helped = helpedStudent10,
                HelpedId = 10,
                Tutor = tutor5,
                TutorId = 5
            };
            tutoringSession.add(tutoringSession11);

            TutoringSession tutoringSession12 = new TutoringSession()
            {
                Id = 12,
                DateTimeSession = new DateTime(2015, 5, 27, 13, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent2,
                HelpedId = 2,
                Tutor = tutor3,
                TutorId = 3
            };
            tutoringSession.add(tutoringSession12);

            TutoringSession tutoringSession13 = new TutoringSession()
            {
                Id = 13,
                DateTimeSession = new DateTime(2015, 6, 1, 9, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent7,
                HelpedId = 7,
                Tutor = tutor7,
                TutorId = 7
            };
            tutoringSession.add(tutoringSession13);

            TutoringSession tutoringSession14 = new TutoringSession()
            {
                Id = 14,
                DateTimeSession = new DateTime(2015, 6, 2, 9, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent11,
                HelpedId = 11,
                Tutor = tutor7,
                TutorId = 7
            };
            tutoringSession.add(tutoringSession14);

            TutoringSession tutoringSession15 = new TutoringSession()
            {
                Id = 15,
                DateTimeSession = new DateTime(2015, 6, 2, 11, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent2,
                HelpedId = 2,
                Tutor = tutor7,
                TutorId = 7
            };
            tutoringSession.add(tutoringSession15);

            TutoringSession tutoringSession16 = new TutoringSession()
            {
                Id = 16,
                DateTimeSession = new DateTime(2015, 6, 2, 13, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent5,
                HelpedId = 5,
                Tutor = tutor1,
                TutorId = 1
            };
            tutoringSession.add(tutoringSession16);

            TutoringSession tutoringSession17 = new TutoringSession()
            {
                Id = 17,
                DateTimeSession = new DateTime(2015, 6, 2, 15, 0, 0),
                LenghtSession = 1,
                Helped = helpedStudent9,
                HelpedId = 9,
                Tutor = tutor4,
                TutorId = 4
            };
            tutoringSession.add(tutoringSession17);

            TutoringSession tutoringSession18 = new TutoringSession()
            {
                Id = 18,
                DateTimeSession = new DateTime(2015, 6, 3, 13, 0, 0),
                LenghtSession = 2,
                Helped = helpedStudent7,
                HelpedId = 7,
                Tutor = tutor3,
                TutorId = 3
            };
            tutoringSession.add(tutoringSession18);


           
        }

        
    }
}
