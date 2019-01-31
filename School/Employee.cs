using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal abstract class Employee //internal - ograniczenie uzywania klasy do assembly
    {
        //private DateTime EmploymentDate; //pole - ma tylko jeden modyfikator, property może mieć inne modyfikatory przy get i set
        public DateTime EmploymentDate { get; private set; }

        //private int workingHours;
        public int WorkingHours { get; private set; }
        //{
        //    get
        //    {
        //        if (workingHours > 0)
        //        {
        //            return workingHours; //return wuchodzi z metody
        //        }
        //        return int.MinValue;
        //    }
        //    private set
        //    {
        //        if (workingHours > 0)
        //        {
        //            workingHours = value;
        //        }
        //        else
        //        {
        //            workingHours = -1;
        //        }

        //    }
    } //property - każdy moze pobrać wartośc ale nie może jej modyfikować

        public void SetWorkingHours (int workingHours)
        {
            if (workingHours > 6 && workingHours <13)
            {
                WorkingHours = workingHours
            }
        }
    }
}
