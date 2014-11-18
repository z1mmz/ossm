﻿using System;
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
        public string subjectCode { get; set; }
        public string subjectDesc { get; set; }
        public string subjectName { get; set; }
        private SubjectClass[] classes { get; set; }
        private Assignment[] assignments { get; set; }

        public Subject(string subjectCode, string subjectDesc, string subjectName)//Default contruct
        {
            this.subjectCode = subjectCode;
            this.subjectDesc = subjectDesc;
            this.subjectName = subjectName;
        }
        public Subject(SerializationInfo info, StreamingContext ctxt)//serial constructor
        {
            subjectCode = info.GetString("SubjectCode");
            classes = (SubjectClass[])info.GetValue("SubjectClass",classes.GetType());
            assignments = (Assignment[])info.GetValue("Assignments", assignments.GetType());
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
