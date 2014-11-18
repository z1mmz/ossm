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
        public SubjectDetails()
        {
            InitializeComponent();
        }
        public SubjectDetails(Subject subject)
        {
            InitializeComponent();
            SubjectCodeBlock.Text = subject.subjectCode;
            subjectDescBlock.Text = subject.subjectDesc;
            subjectNameBlock.Text = subject.subjectName;

        }
    }
}
