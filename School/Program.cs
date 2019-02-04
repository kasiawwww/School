using System;
using System.Collections;
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
            int[] ints = new int[] { 11, 2, 31 };
            int x = ints.Length;
            Array.Sort(ints);
            Array.Reverse(ints);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            ArrayList aList = new ArrayList(); //nie uzywac, mozna przypisac różne typy, generuje błędy
            aList.Add("Roman");
            aList.Add(3);
            aList.Add(34.5m);
            //aList.Sort();//nie działa bo rózne typy
            aList.Remove("Roman");
            //aList.Sort();

            Hashtable hTable = new Hashtable();
            //hTable.Add(1, "Roman");
            // hTable.Add("Jaś", 34);

            // object o = hTable[1];

            Queue q = new Queue();
            q.Enqueue("Roman");
            q.Enqueue(1);
            q.Enqueue(32.5);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            Console.WriteLine("--------------------------");

            Stack s = new Stack();
            s.Push("Roman");
            s.Push(1);
            s.Push(22.458);

            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine("--------------------------");

            HashSet<int> hash = new HashSet<int>();
            hash.Add(2);
            hash.Add(1);
            hash.Add(2);

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            Dictionary<int, Teacher> teachers = new Dictionary<int, Teacher>();
            var teacher = new Teacher();
            teacher.Name = "Kowalski";
            teachers.Add(1, new Teacher {  Name = "Nowak"});
            teachers.Add(2, teacher);
            teachers[1] = new Teacher { Name = "Miś" };

            var a = teachers.Keys;
            var b = teachers.Values;
            foreach (var Id in teachers.Keys)
            {
                Console.WriteLine(teachers[Id].Name);
            }
            Console.WriteLine("--------------------------");

            List<string> employees = new List<string>();
            employees.Add("roman");
            employees.Add("asia");
            employees.Add("kasia");

            Console.WriteLine(employees[0]);
            employees.ForEach(xx => Console.WriteLine(xx));

            Employee teacher1 = new Teacher();
            //teacher.EmploymentDate = new DateTime(2019, 1, 31) -> nie zadziała, modyfikator private na set
            teacher.SetEmploymentDate(new DateTime(1999, 1, 1));
            Console.WriteLine(teacher1.EmploymentDate);
            teacher.SetWorkingHours(10);
            Console.WriteLine(teacher1.GetWorkingHours());
            Console.Read();
        }
    }
}
