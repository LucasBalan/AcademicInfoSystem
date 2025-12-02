using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class Subject
    {
        private long subjectId;
        private string name;
        private string language;
        private string classnumber;


        public Subject(long subjectId, string name, string language, string classnumber)
        {
            SubjectId = subjectId;
            Name = name;
            Language = language;
            Classnumber = classnumber;
         
        }

        public long SubjectId
        {
            get { return subjectId; }
            private set { subjectId = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Language
        {
            get { return language; }
            private set { language = value; }
        }

        public string Classnumber
        {
            get { return classnumber; }
            private set { classnumber = value; }
        }

    }
}
