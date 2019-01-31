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
        public DateTime EmploymentDate { get; private set; } = new DateTime(2000, 1, 1);

        //private DateTime date = new DateTime(2000, 1, 1, 0, 0, 0);
        //private int workingHours;
        protected int WorkingHours { get; private set; }
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
     //property - każdy moze pobrać wartośc ale nie może jej modyfikować
     //klasa abstrakcyjna od interfejsu -> klasa abst może mieć metody które mają ciało a interfejs nie

        public void SetWorkingHours (int workingHours)
        {
            if (workingHours > 6 && workingHours <13)
            {
                WorkingHours = workingHours;
            }
        }

        /// <summary>
        /// Ta metoda ustawia datę zatrudnienia.
        /// </summary>
        /// <param name="employmentDate"></param>
        public void SetEmploymentDate(DateTime employmentDate)
        {
            //if (DateTime.Compare(date, employmentDate) >= 0)
            //{
            //    EmploymentDate = date;
            //}
            //else
            //{
            //    EmploymentDate = employmentDate;
            //}

            //if (employmentDate > EmploymentDate)
            //    EmploymentDate = employmentDate;

            EmploymentDate = (employmentDate > EmploymentDate) ? employmentDate : EmploymentDate;
        }

        public abstract bool IsWorking(); //abstrakcyjne metody musza zostać zaimplementowane (przesłonięte)
        public virtual int GetWorkingHours() //wirtualne metody moga być przesłonięte
        {
            return 0;
        }

        public virtual int GetWorkingHours(string dayName) //wirtualne metody moga być przesłonięte
        {
            return 0;
        }
        public virtual int GetWorkingHours(string dayName, DateTime from) //wirtualne metody moga być przesłonięte
        {
            return 0;
        }
    }
}
