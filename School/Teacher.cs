using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Teacher : Employee
    {
        public string Name { get; set; }
        private int DailyHours { get; set; }

        internal Teacher() //konstruktor
        {
            DailyHours = 4;
        }
        internal Teacher(int dailyHours) //konstruktor
        {
            DailyHours = dailyHours;
        }
        public override bool IsWorking()
        {
            //if (DailyHours >= 8)
            //{
            //    return false;
            //}
            //return true;
            return (DailyHours < 8);
        }

        // Tu pokazać brak tej metody.
        public void SetWorkingHoursFromBase(int hours)
        {
            base.SetWorkingHours(hours);
        }

        public override int GetWorkingHours()
        {
            return GetWorkingHoursFromBase();
        }
        public int GetWorkingHoursFromBase()
        {
            return WorkingHours;
        }
    }
}
