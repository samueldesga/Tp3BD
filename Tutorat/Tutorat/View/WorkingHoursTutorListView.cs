using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.View
{
    class WorkingHoursTutorListView
    {
        private IEnumerable<WorkingHoursTutorListVM> tutorList;

        public WorkingHoursTutorListView(IEnumerable<WorkingHoursTutorListVM> _tutorList)
        {
            tutorList = _tutorList;
        }


        public void Display()
        {
            foreach (WorkingHoursTutorListVM t in tutorList)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
