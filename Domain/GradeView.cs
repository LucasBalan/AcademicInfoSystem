using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class GradeView
    {
        public string SubjectName { get; set; }
        public double GradeValue { get; set; }
        public DateTime GradeDate { get; set; }
        public string TeacherName { get; set; }
    }
}
