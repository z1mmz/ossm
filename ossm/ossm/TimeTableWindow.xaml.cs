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
    /// Interaction logic for TimeTableWindow.xaml
    /// </summary>
    public partial class TimeTableWindow : Window
    {
        appDriver _appDriver;
        public TimeTableWindow(appDriver _appdriver)
        {
            InitializeComponent();
            this._appDriver = _appdriver;
            FillDataGrid();
        }
        private void FillDataGrid(){
            
            TextBlock text1 = new TextBlock();
            //text1.Name;
            text1.Text = "Digger";
            text1.FontSize = 10;
            text1.FontWeight = FontWeights.Bold;
            string day = null;
            List<Subject> subjects = _appDriver.subjects;
            
            int column = 0;
            int row = 0;
            string time = null;
            for (int i = 0; i < subjects.Count; i++)
            {
                List<SubjectClass> classes = subjects[i].classes;
                try{
                for (int x = 0; x < classes.Count; x++)
                {
                    day = classes[x].getDay();

                    switch (day)
                    {
                        case "monday":
                            column = 2;
                            break;
                        case "tuesday":
                            column = 3;
                            break;
                        case "wednesday":
                            column = 4;
                            break;
                        case "thursday":
                            column = 5;
                            break;
                        case "friday":
                            column = 6;
                            break;
                        case "saturday":
                            column = 7;
                            break;
                        case "sunday":
                            column = 8;
                            break;
                    }
                    time = classes[x].getTime();
                    switch (time)
                    {
                        case "6:00AM":
                            row = 0;
                            break;
                        case "6:30AM":
                            row = 1;
                            break;
                        case "7:00AM":
                            row = 2;
                            break;
                        case "7:30AM":
                            row = 3;
                            break;
                        case "8:00AM":
                            row = 4;
                            break;
                        case "8:30AM":
                            row = 5;
                            break;
                        case "9:00AM":
                            row = 6;
                            break;
                        case "9:30AM":
                            row = 7;
                            break;
                        case "10:00AM":
                            row = 8;
                            break;
                        case "10:30AM":
                            row = 9;
                            break;
                        case "11:00AM":
                            row = 10;
                            break;
                        case "11:30AM":
                            row = 11;
                            break;
                        case "12:00PM":
                            row = 12;
                            break;
                        case "12:30PM":
                            row = 13;
                            break;
                        case "1:00PM":
                            row = 14;
                            break;
                        case "1:30PM":
                            row = 15;
                            break;
                        case "2:00PM":
                            row = 16;
                            break;
                        case "2:30PM":
                            row = 17;
                            break;
                        case "3:00PM":
                            row = 18;
                            break;
                        case "3:30PM":
                            row = 19;
                            break;
                        case "4:00PM":
                            row = 20;
                            break;
                        case "4:30PM":
                            row = 21;
                            break;
                        case "5:00PM":
                            row = 22;
                            break;
                        case "5:30PM":
                            row = 23;
                            break;
                        case "6:00PM":
                            row = 24;
                            break;
                        case "6:30PM":
                            row = 25;
                            break;
                        case "7:00PM":
                            row = 26;
                            break;
                        case "7:30PM":
                            row = 27;
                            break;
                        case "8:30PM":
                            row = 28;
                            break;
                        case "9:00PM":
                            row = 29;
                            break;
                    }
                    Grid.SetColumnSpan(text1, 1);
                    Grid.SetRow(text1, row);
                    Grid.SetColumn(text1, column);
                    timeTableGrid.Children.Add(text1);
                }
                }
                catch(NullReferenceException e)
                {

                }
            }
            timeTableGrid.UpdateLayout();
        }

        private void addClass_Click(object sender, RoutedEventArgs e)
        {
            Window addClass = new addClassTimetableWindow(_appDriver);
            addClass.Show();
        }
    }
}
