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

namespace ossm
{
    /// <summary>
    /// Interaction logic for SubjectDetails.xaml
    /// </summary>
    public partial class SubjectDetails : Window
    {
        private appDriver _appdriver;
        List<Assignment> assignments;
        List<string> data = new List<string>();
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
            if (data.Count == 0)
            {
                data.Add("No assignments");
            }
            assListBox.ItemsSource = data;

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
    }
}
