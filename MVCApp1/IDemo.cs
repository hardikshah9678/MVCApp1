using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp1
{
    public class Data
    {
        public string FName { get; set; }
        public string LName { get; set; }
    }
    public interface IDemo1
    {
        Data GetDetails();
    }

    public interface IDemo2
    {
        Data GetDetails();
    }

    public class InterfaceTest : IDemo1, IDemo2
    {
        Data IDemo1.GetDetails()
        {
            return new Data { FName = "Fname Details1", LName="LName Detail1" };
        }

        Data IDemo2.GetDetails()
        {
            return new Data { FName = "Fname Details2", LName = "LName Detail2" };
        }   
    }

}
