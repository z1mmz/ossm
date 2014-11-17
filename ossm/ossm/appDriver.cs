﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
    [Serializable()]

    public class appDriver : ISerializable
    {
        //public static appDriver() { }
        public static readonly string _FILE_PATH = "Save.DAT";

   
        public List<Subject> subjects = new List<Subject>();

        public appDriver()
        {

        }
        public void addSubject(string code){

        subjects.Add(new Subject(code));

        }
        public List<Subject> getSubjects()
        {
            return subjects;
        }
        public appDriver(SerializationInfo info, StreamingContext ctxt)//serial constructor
        {
            subjects = (List<Subject>)info.GetValue("subjects", subjects.GetType());
          
            //add serial construction here
        }

        //Serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("subjects", subjects);
         
        }
        public static void saveToFile(appDriver _appDriver)
        {
            using (FileStream fileStream = new FileStream(_FILE_PATH, FileMode.OpenOrCreate))
            {
                BinaryFormatter BinForm = new BinaryFormatter();
                BinForm.Serialize(fileStream, _appDriver);
                fileStream.Close();
            }
        }
        public static appDriver loadFromFile()
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(_FILE_PATH,FileMode.Open);
                BinaryFormatter binForm = new BinaryFormatter();
                return (appDriver)binForm.Deserialize(fileStream);
            }
            catch
            {
                return new appDriver();
            }
            finally
            {
                fileStream.Close();
            }
        }
        

    }
}
