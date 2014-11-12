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
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<string> data = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            fillComboBox();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //Populate the combo box
        public void fillComboBox()
        {
            
            List<Subject> subjects = appDriver.getSubjects();
           subjects.ForEach(Subject => data.Add(Subject.getCode().ToString()));
            
            
            ClassComboBox.ItemsSource = data; 
        }
        public void fillComboBox(string a)
        {
             data.Add(a);
            ClassComboBox.ItemsSource = data;
        }

        private void addClass(object sender, RoutedEventArgs e)
        {
            Window newWindow = new addClassWindow();
            newWindow.Show();
            this.Close();
            
            

        }
    }
}
