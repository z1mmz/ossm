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
    /// Interaction logic for addClassTimetableWindow.xaml
    /// </summary>
    public partial class addClassTimetableWindow : Window
    {
        appDriver _appDriver;
        public addClassTimetableWindow(appDriver _appDriver)
        {
            this._appDriver = _appDriver;
            InitializeComponent();
            fillContent();
        }
        private void fillContent(){
            List<Subject> subjects = _appDriver.getSubjects();
            List<string> data = new List<string>();
            for(int i = 0; i <subjects.Count ; i ++){
                data.Add(subjects[i].getCode().ToString());
            }
            subjectCombo.Items.Clear();
            subjectCombo.ItemsSource = data;
            subjectCombo.Items.Refresh();
            List<string> timeData = new List<string>();
            //NEED TO THINK ABOUT HOW TIME WILL BE STORED AND DISPLAYED
            
        }
    }
}
