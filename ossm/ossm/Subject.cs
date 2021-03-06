﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;
//         _______                   _____                    _____                    _____          
//        /::\    \                 /\    \                  /\    \                  /\    \         
//       /::::\    \               /::\    \                /::\    \                /::\____\        
//      /::::::\    \             /::::\    \              /::::\    \              /::::|   |        
//     /::::::::\    \           /::::::\    \            /::::::\    \            /:::::|   |        
//    /:::/~~\:::\    \         /:::/\:::\    \          /:::/\:::\    \          /::::::|   |        
//   /:::/    \:::\    \       /:::/__\:::\    \        /:::/__\:::\    \        /:::/|::|   |        
//  /:::/    / \:::\    \      \:::\   \:::\    \       \:::\   \:::\    \      /:::/ |::|   |        
// /:::/____/   \:::\____\   ___\:::\   \:::\    \    ___\:::\   \:::\    \    /:::/  |::|___|______  
//|:::|    |     |:::|    | /\   \:::\   \:::\    \  /\   \:::\   \:::\    \  /:::/   |::::::::\    \ 
//|:::|____|     |:::|    |/::\   \:::\   \:::\____\/::\   \:::\   \:::\____\/:::/    |:::::::::\____\
// \:::\    \   /:::/    / \:::\   \:::\   \::/    /\:::\   \:::\   \::/    /\::/    / ~~~~~/:::/    /
//  \:::\    \ /:::/    /   \:::\   \:::\   \/____/  \:::\   \:::\   \/____/  \/____/      /:::/    / 
//   \:::\    /:::/    /     \:::\   \:::\    \       \:::\   \:::\    \                  /:::/    /  
//    \:::\__/:::/    /       \:::\   \:::\____\       \:::\   \:::\____\                /:::/    /   
//     \::::::::/    /         \:::\  /:::/    /        \:::\  /:::/    /               /:::/    /    
//      \::::::/    /           \:::\/:::/    /          \:::\/:::/    /               /:::/    /     
//       \::::/    /             \::::::/    /            \::::::/    /               /:::/    /      
//        \::/____/               \::::/    /              \::::/    /               /:::/    /       
//         ~~                      \::/    /                \::/    /                \::/    /        
//                                  \/____/                  \/____/                  \/____/    
//Subject class 
//holds data regaring subjects
namespace ossm
{
    [Serializable()]
    public class Subject
    {
        public string subjectCode { get; set; }
        public string subjectDesc { get; set; }
        public string subjectName { get; set; }
        public List<SubjectClass> classes;
        private List<Assignment> assignments;
        public string filePath;

        public Subject(string subjectCode, string subjectDesc, string subjectName)//constructor
        {
            this.subjectCode = subjectCode;
            this.subjectDesc = subjectDesc;
            this.subjectName = subjectName;
            this.filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\" +"OSSM"+"\\" + subjectCode ;
            if (!Directory.Exists(filePath))
            {
                    Directory.CreateDirectory(this.filePath);
                
            }
        }

        //No longer used due to update using appdriver saving array of objects
        //public Subject(SerializationInfo info, StreamingContext ctxt)//serial constructor
        //{
        //    subjectCode = info.GetString("SubjectCode");
        //    classes = (SubjectClass[])info.GetValue("SubjectClass",classes.GetType());
        //    assignments = (Assignment[])info.GetValue("Assignments", assignments.GetType());
        //    //add serial construction here
        //}
        ////Serialization function
        //public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        //{
        //    info.AddValue("SubjectCode", subjectCode);
        //    info.AddValue("SubjectClass", classes);
        //    info.AddValue("Assignments", assignments);
        //}
        public string getCode()
        {
            return subjectCode;
        }
        public List<Assignment> getAssignments()
        {
            List<Assignment> derp = assignments;
            return derp;
        }
        public void addClass(string time, string day)
        {
            SubjectClass temp = new SubjectClass(time, day, subjectCode);
            classes.Add(temp);
        }
        

 
    }
}
