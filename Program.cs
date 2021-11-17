using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = RetriveStudentFromDB();

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();
            controller.SetStudentName("Romina");
            controller.UpdateView();

            Console.ReadKey();
           
        }

        private static Student RetriveStudentFromDB()
        {
            Student s = new Student("123", "Mumi");
            return s;
        }
    }
}
