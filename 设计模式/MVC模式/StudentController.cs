using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC模式
{
    /// <summary>
    /// 步骤 3 创建控制器。
    /// </summary>
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setStudentName(String name)
        {
            model.Name =name;
        }

        public String getStudentName()
        {
            return model.Name;
        }

        public void setStudentRollNo(String rollNo)
        {
            model.RollNo =rollNo;
        }

        public String getStudentRollNo()
        {
            return model.RollNo;
        }

        public void updateView()
        {
            view.printStudentDetails(model.Name, model.RollNo);
        }
    }
}
