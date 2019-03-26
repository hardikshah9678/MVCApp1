using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp1.Memento
{
    public class CallingMemento
    {
        public void MementoWrapper()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Hardik";
            s.Phone = "1231231231212";
            s.Budget = 100000.00;

            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = s.SaveMemento();

            s.Name = "Hardik1";
            s.Phone = "99999999";
            s.Budget = 200000.00;
            s.RestoreMemento(prospectMemory.Memento);

            var name = s.Name;
        }
    }
}