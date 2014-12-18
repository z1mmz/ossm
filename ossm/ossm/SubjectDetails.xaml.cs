using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace ossm
{
    /// <summary>
    /// Interaction logic for SubjectDetails.xaml
    /// </summary>
    public partial class SubjectDetails : Window
    {
        private appDriver _appdriver;
        List<Subject> subjects;
        List<Assignment> assignments;
        List<string> data = new List<string>();
        List<FileInfo> Files = new List<FileInfo>();
        List<string> fileNames = new List<string>();
        DirectoryInfo info;
        string subjectFilePath;
        public SubjectDetails()
        {
            InitializeComponent();
        }
        public SubjectDetails(Subject subject,appDriver _appDriver)
        {
            InitializeComponent();
            this._appdriver = _appDriver;
            SubjectCodeBlock.Text = subject.subjectCode;
            subjectDescBlock.Text = subject.subjectDesc;
            subjectNameBlock.Text = subject.subjectName;
            getAssignments(subject.subjectCode);
            populateFileList();
            if (Files.Count == 0)
            {
                fileNames.Add("No Files");   
            }
            if (data.Count == 0)
            {
                data.Add("No assignments");
            }
            FileListBox.ItemsSource = fileNames;
            assListBox.ItemsSource = data;

        }

        private void populateFileList()
        {
            
            subjects = _appdriver.getSubjects();
            for(int i = 0; i < subjects.Count ; i++)
            {
                if (subjects[i].getCode() == SubjectCodeBlock.Text)
                {
                    info = new DirectoryInfo(subjects[i].filePath);
                    subjectFilePath = subjects[i].filePath;
                }
            
            }
            Files = info.GetFiles().ToList();
            for (int i = 0; i < Files.Count; i++)
            {
                fileNames.Add(Files[i].Name);
            }
            
        }
        private void getAssignments(String SubjectCode)
        {
            List<Subject> subjects = _appdriver.getSubjects();
            for (int i = 0; i < subjects.Count(); i++)
            {
                if (SubjectCodeBlock.Text == subjects[i].getCode())
                {
                   assignments = subjects[i].getAssignments();
                   if (assignments == null)
                   {
                       break;
                   }
                   assignments.ForEach(Assignment => data.Add(Assignment.getAssignmentString()));
                }
            }
        }

        private void FileListBoxSelect(object sender, MouseButtonEventArgs e)
        {
            if (!(FileListBox.SelectedItem == null))
            {
                string selectedItem = FileListBox.SelectedItem.ToString();
                string filePath = subjectFilePath + "\\" + selectedItem;
                try
                {
                    System.Diagnostics.Process.Start(@filePath);
                }
                catch (System.ComponentModel.Win32Exception x)
                {
                    //do nothinng because there are no files
                }
            }
        }

        private void Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo fi = new FileInfo(files[i]);
                    if (Directory.Exists(files[i]))
                    {
                        string[] folderFileNames = Directory.GetFiles(files[i]);
                        for (int x = 0; x < folderFileNames.Length; x++)
                        {
                            FileInfo folderFi = new FileInfo(folderFileNames[x]);
                            File.Copy(folderFileNames[x], subjectFilePath + "\\" + folderFi.Name);
                        }
                    }
                    else
                    {
                        File.Copy(files[i], subjectFilePath + "\\" + fi.Name);
                    }
                    fileNames.Clear();
                    populateFileList();
                    FileListBox.Items.Refresh();
                }
            }
        }
    }
}
