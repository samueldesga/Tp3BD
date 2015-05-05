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
        IEnumerable<TutorListVM> tutorList;

        TutorListView(IEnumerable<TutorListVM> _tutorList)
        {
            tutorList = _tutorList;
        }

        public void Display()
        {
            Console.WriteLine(tutorList.ToString());
        }

        

    }
}
