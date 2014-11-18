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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ossm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// main application window
    /// </summary>
    public partial class MainWindow : Window
    {
        private appDriver _appDriver;
        List<Subject> subjects;
        
        List<string> data = new List<string>();
        public MainWindow()
        {
             
            InitializeComponent();
            _appDriver = appDriver.loadFromFile();
            fillComboBox();
        
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //Populate the combo box
        public void fillComboBox()
        {
            
           subjects = _appDriver.getSubjects();
           subjects.ForEach(Subject => data.Add(Subject.getCode().ToString()));
           data.Sort();
            
            ClassComboBox.ItemsSource = data; 
        }
        //TEST FUNCTION
        //public void fillComboBox(string a)
        //{
        //     data.Add(a);
        //    ClassComboBox.ItemsSource = data;
        //}

        //Add subject button 
        private void addClass(object sender, RoutedEventArgs e)
        {
            //starts new addClasswindow
            Window newWindow = new addClassWindow(_appDriver);
            newWindow.Show();
            //closes main window which causes appDriver to save
            this.Close();
        }

        //private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
          
            
            
        //}
        
        // view details button starts new window for interaction with subject
        private void viewNotesClick(object sender, RoutedEventArgs e)
        {
            ComboBox test = ClassComboBox;
            string text = test.Text;

            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].getCode() == text)
                {
                    Window subjectDetailWindow = new SubjectDetails(subjects[i],_appDriver);
                    subjectDetailWindow.Show();
                }
            }
            
        }
        //onclose overide to make appDriver save
       protected override void OnClosed(EventArgs e)
        {
            appDriver.saveToFile(_appDriver);
            base.OnClosed(e);
        }
    }
}
