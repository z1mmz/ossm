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
    /// Interaction logic for addClassWindow.xaml
    /// </summary>
    public partial class addClassWindow : Window
    {
        private appDriver _appDriver;
        
        public addClassWindow()
        {
            InitializeComponent();
        }
        //get pass instance of appDriver
        public addClassWindow(appDriver _appDriver)
        {
            InitializeComponent();
            this._appDriver = _appDriver;
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
            /* do rest of loading for class data here 
             * will implement methods in appDriver
             */
            // save appDriver as it will be reloaded in mainwindow
           //appDriver.saveToFile(_appDriver);
           //Window MainWindow = new MainWindow();
           //MainWindow.Show();
           closeAndSave();
           
            
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
           //appDriver.saveToFile(_appDriver);
           //Window MainWindow = new MainWindow();
           //MainWindow.Show();
           //this.Close(
           Window MainWindow = new MainWindow();
            MainWindow.Show();

            base.OnClosing(e);
        }
        public void closeAndSave()
        {
            
            this.Close();
           
        }


    }
}
