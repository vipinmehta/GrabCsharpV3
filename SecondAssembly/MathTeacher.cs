using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssembly
{
    public class MathTeacher:Teacher
    {
        public string MyMethod()
        {
            return base.GetTeacherName("firstname", "lastname");
        }
    }
}
