using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC模式
{
    /// <summary>
    /// 步骤 2 创建视图。
    /// </summary>
    public class StudentView
    {
        public void printStudentDetails(String studentName, String studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
