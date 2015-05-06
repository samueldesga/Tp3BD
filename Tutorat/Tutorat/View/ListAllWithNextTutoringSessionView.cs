using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.View
{
    class ListAllWithNextTutoringSessionView
    {
        private IEnumerable<ListAllWitnNextTutoringSessionVM> tutorSessionList;

        public ListAllWithNextTutoringSessionView(IEnumerable<ListAllWitnNextTutoringSessionVM> _tutorSessionList)
        {
            tutorSessionList = _tutorSessionList;
        }


        public void Display()
        {
            foreach (ListAllWitnNextTutoringSessionVM t in tutorSessionList)
            {

                Console.WriteLine(t.ToString());
            }
        }
    }
}
