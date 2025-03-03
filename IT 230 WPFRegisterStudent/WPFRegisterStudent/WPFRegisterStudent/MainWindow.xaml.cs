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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        private int totalCredits = 0; 
        private const int MAX_CREDITS = 9; 
        private List<Course> registeredCourses = new List<Course>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                choice = (Course)(this.comboBox.SelectedItem);
                if (registeredCourses.Contains(choice))
                {
                    label3.Content = $"You have already registered for this {choice.ToString()} course.";
                    return;
                }
                if (totalCredits + 3 > MAX_CREDITS)
                {
                    label3.Content = $"You can not register for more than 9 credit hours.";
                    return;
                }
                registeredCourses.Add(choice);
                listBox.Items.Add(choice.ToString());
                totalCredits += 3;
                textBox.Text = $"{totalCredits}";
                label3.Content = $"Registration Confirmed for course {choice.ToString()}.";
            }
        }

    }
}
