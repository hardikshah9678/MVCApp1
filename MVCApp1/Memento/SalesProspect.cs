using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp1.Memento
{
    public class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(Name,Phone,Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}