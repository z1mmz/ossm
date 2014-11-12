using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ossm
{
    [Serializable()]
    public class Subject
    {
        private string subjectCode;
        private SubjectClass[] classes;
        private Assignment[] assignments;
        public Subject(string subjectCode)//Default contruct
        {
            this.subjectCode = subjectCode;
        }
        public Subject(SerializationInfo info, StreamingContext ctxt)//serial constructor
        {

            //add serial construction here
        }
        //Serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("SubjectCode", subjectCode);
            info.AddValue("SubjectClass", classes);
            info.AddValue("Assignments", assignments);
        }
        public string getCode()
        {
            return subjectCode;
        }
        

 
    }
}
