using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student _model, StudentView _view)
        {
            this.model = _model;
            this.view = _view;
        }
        public void SetStudentName(string name) {
            model.Name = name;

        }

        public string GetStudentName() {

            return model.Name;
        }

        public void SetStudentRollNo(string rollNo) {
            model.RollNo = rollNo;
        }

        public string GetStudentRollNo() {
            return model.RollNo;
        }

        public void UpdateView() {
            view.PrintStudentDetails(model.Name, model.RollNo);
        }
    }
}
