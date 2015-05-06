using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.View
{
    class TutorListView
    {
        private IEnumerable<TutorListVM> tutorList;

        public TutorListView(IEnumerable<TutorListVM> _tutorList)
        {
            tutorList = _tutorList;
        }


        public void Display()
        {
            foreach(TutorListVM t in tutorList)
            {

            Console.WriteLine(t.ToString());
            }
        }



    }
}
