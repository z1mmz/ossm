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
 * Main class most data manipulation will take place here
 * Class is not static anymore you need to create a referance for it in your class and save it using saveToFile(_appData)
 * Windows pass Data to this class
 * KEEP PROCESSING OUT OF GUI CLASSES
 * THIS CLASS IS SERIALIZED TO SAVE DATA CLASSES in array
 * I know this is not ideal but hey it works
 * 
 * CURRENT BUGS
 */
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
// _______                         _______                                   _______ __            __             _______                                     
//|       |.-----.-----.-----.    |     __|.-----.--.--.----.----.-----.    |     __|  |_.--.--.--|  |.--.--.    |   |   |.---.-.-----.---.-.-----.-----.----.
//|   -   ||  _  |  -__|     |    |__     ||  _  |  |  |   _|  __|  -__|    |__     |   _|  |  |  _  ||  |  |    |       ||  _  |     |  _  |  _  |  -__|   _|
//|_______||   __|_____|__|__|    |_______||_____|_____|__| |____|_____|    |_______|____|_____|_____||___  |    |__|_|__||___._|__|__|___._|___  |_____|__|  
//         |__|                                                                                       |_____|                               |_____|           

                                                                                                                                                                                          
namespace ossm
{
    [Serializable()]

    public class appDriver : ISerializable
    {
        //public static appDriver() { }
        public static readonly string _FILE_PATH = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\" +"OSSM"+"\\"+"Save.DAT";

   
        public  List<Subject> subjects = new List<Subject>();

        public appDriver()
        {

        }
        public void addSubject(string subjectCode, string subjectDesc, string subjectName){

            subjects.Add(new Subject(subjectCode, subjectDesc, subjectName));

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
            try
            {
                using (FileStream fileStream = new FileStream(_FILE_PATH, FileMode.OpenOrCreate))
                {
                    BinaryFormatter BinForm = new BinaryFormatter();
                    BinForm.Serialize(fileStream, _appDriver);
                    fileStream.Close();
                }
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
               
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
                if (fileStream != null)fileStream.Close();
            }
        }
        
   
        

    }
}
