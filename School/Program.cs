using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee teacher = new Teacher();
            //teacher.EmploymentDate = new DateTime(2019, 1, 31) -> nie zadziała, modyfikator private na set
            teacher.SetWorkingHours(16);

        }
    }
}
