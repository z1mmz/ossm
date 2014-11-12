using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossm
{
    public static class appDriver
    {
        //public static appDriver() { }

   
        public static List<Subject> subjects = new List<Subject>();
    
        public static void addSubject(string code){
            subjects.Add(new Subject(code));
        }
        public static List<Subject> getSubjects()
        {
            return subjects;
        }

    }
}
