using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * AUTHOR WOLF ZIMMERMANN 2014
 * Main class
 * Windows pass Data to this class
 * KEEP PROCESSING OUT OF GUI CLASSES
 * 
 * C# != JAVA
 */

 
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
