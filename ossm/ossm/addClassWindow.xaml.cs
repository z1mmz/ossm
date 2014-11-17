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
            string code = subjectCodeText.Text;
           _appDriver.addSubject(code);
           appDriver.saveToFile(_appDriver);
           Window MainWindow = new MainWindow();
           MainWindow.Show();
           this.Close();
            
        }


    }
}
