using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ProjectDLL
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceStudent studentService = new ServiceStudent();
            //studentService.AddS(new Student { Name = "Ivan", Lastname = "Ivanow", Age = 20 });
            //studentService.AddS(new Student { Name = "Petro", Lastname = "Petrov", Age = 30 });
            //Random rnd = new Random();
            //foreach(Student el in studentService.Students)
            //{
            //    el.AddMark("C++", rnd.Next(1, 12));
            //    el.AddMark("C#", rnd.Next(1, 12));
            //}
            foreach (Student el in studentService.Students)
            {
                Console.WriteLine(el);
            }
            studentService.Save();
        }
    }
}
