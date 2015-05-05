﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorat.ViewModel;

namespace Tutorat.View
{
    class SessionListView
    {
        IEnumerable<TutoringSessionListVM> sessionList;

        SessionListView(IEnumerable<TutoringSessionListVM> _sessionList)
        {
            sessionList = _sessionList;
        }

        public void Display()
        {
            Console.WriteLine(sessionList.ToString());
        }
    }
}