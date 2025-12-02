using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class Grade
    {
        private long gradeId;
        private long subjectId;
        private long studentId;
        private long teacherId;
        private double gradeValue;
        private DateTime date;


        public Grade(long gradeId, long subjectId, long studentId, long teacherId, double gradeValue, DateTime date)
        {
            GradeId = gradeId;
            SubjectId = subjectId;
            StudentId = studentId;
            TeacherId = teacherId;
            GradeValue = gradeValue;
            Date = date;
        }



        public long GradeId
        {
            get { return gradeId; }
            private set { gradeId = value; }
        }
        public long SubjectId
        {
            get { return subjectId; }
            private set { subjectId = value; }
        }
        public long StudentId
        {
            get { return studentId; }
            private set { studentId = value; }
        }
        public long TeacherId
        {
            get { return teacherId; }
            private set { teacherId = value; }
        }
        public double GradeValue
        {
            get { return gradeValue; }
            private set { gradeValue = value; }
        }
        public DateTime Date
        {
            get { return date; }
            private set { date = value; }
        }
    }
}
