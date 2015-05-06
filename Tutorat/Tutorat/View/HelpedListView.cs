using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.View
{
    class HelpedListView
    {
        IEnumerable<HelpedListVM> helpedList;

        public HelpedListView(IEnumerable<HelpedListVM> _helpedList)
        {
            helpedList = _helpedList;
        }

        public void Display()
        {
            foreach (HelpedListVM h in helpedList)
            {
                Console.WriteLine(h.ToString());
            }
        }
    }
}
