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
            //Window test = new Window2();
            //test.Show();
            DataContext = this.DataContext;
        
        }

        //Populate the combo box
        public void fillComboBox()
        {
            data.Clear();
           subjects = _appDriver.getSubjects();
           subjects.ForEach(Subject => data.Add(Subject.getCode().ToString()));
           data.Sort();
           ClassComboBox.ItemsSource = data;
           ClassComboBox.Items.Refresh();
           SubjectListDeleteBox.ItemsSource = data;
           SubjectListDeleteBox.Items.Refresh();
          
           
        }

        //Add subject button 
        private void addClass(object sender, RoutedEventArgs e)
        {
            //starts new addClasswindow
            Window newWindow = new addClassWindow(_appDriver);
            newWindow.Show();
            //closes main window which causes appDriver to save
            this.Close();
        }
        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ClassComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox test = ClassComboBox;
            if (!(test.SelectedItem.ToString() == null))
            {
                string text = test.SelectedItem.ToString();

                for (int i = 0; i < subjects.Count; i++)
                {
                    if (subjects[i].getCode() == text)
                    {
                        Window subjectDetailWindow = new SubjectDetails(subjects[i], _appDriver);
                        subjectDetailWindow.Show();
                    }
                }
            }
            
        }
        
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
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            appDriver.saveToFile(_appDriver);
            base.OnClosing(e);
        }

       private void timeTableButton_Click(object sender, RoutedEventArgs e)
       {

       }
       private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
       {

       }

       private void AddSubjectClick(object sender, RoutedEventArgs e)
       {
           if (!(subjectCodeText.Text == null))
           {
               string code = subjectCodeText.Text;
               string name = subjectNameBox.Text;
               string desc = subjectDescBox.Text;
               _appDriver.addSubject(code, desc, name);
           }
           
           appDriver.saveToFile(_appDriver);
           fillComboBox();
           HomeTab.IsSelected = true;
           
           /* do rest of loading for class data here 
            * will implement methods in appDriver
            */
           // save appDriver as it will be reloaded in mainwindow
           //appDriver.saveToFile(_appDriver);
           //Window MainWindow = new MainWindow();
           //MainWindow.Show();
           //closeAndSave();


       }

       private void CloseButton(object sender, System.Windows.RoutedEventArgs e)
       {
       	this.Close();
       }

       private void MinimiseButton(object sender, System.Windows.RoutedEventArgs e)
       {
           this.WindowState = WindowState.Minimized;
       }

       private void ClassComboBoxContext(object sender, ContextMenuEventArgs e)
       {
           
       }

          private void SubjectListDeleteBoxClick(object sender, MouseButtonEventArgs e)
       {
           
           string text = SubjectListDeleteBox.SelectedItem.ToString();

           for (int i = 0; i < subjects.Count; i++)
           {
               if (subjects[i].getCode() == text)
               {
                   _appDriver.subjects.Remove(subjects[i]);
               }
           }
           fillComboBox();

       }
       //protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
       //{
       //    //appDriver.saveToFile(_appDriver);
       //    //Window MainWindow = new MainWindow();
       //    //MainWindow.Show();
       //    //this.Close(
       //    Window MainWindow = new MainWindow();
       //    MainWindow.Show();

       //    base.OnClosing(e);
       //}
    }
}
