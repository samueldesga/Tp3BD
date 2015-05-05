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

        HelpedListView(IEnumerable<HelpedListVM> _helpedList)
        {
            helpedList = _helpedList;
        }

        public void Display()
        {
            Console.WriteLine(helpedList.ToString());
        }
    }
}
