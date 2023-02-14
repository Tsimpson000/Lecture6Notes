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


//What is a method?
//A block of code that is given a name and runs when it is called

//What is the purpose of a method?
//Reuse a block of code over and over to be more effiecient

//What is a class method?
//Class method directly interacts with the members of a class

//Review: What’s the name for any field, constructor, property or method that is part of a class?
//Members

//Review: What are the 4 parts of declaring a method?
//Access modifier (public, private, etc), return type (int, double, etc), Name, Parameters

//What keyword allows you to access members related to the specific instance?
//this

//A method build inside a class has access to what, even it’s access modifier is set to private?
//objects

//What does “override .ToString()” allow us to do?
//creates a string that returns whatever object(s) listed.

//You use the *____ operator* do you use to access members inside of an instanced class?
//The . (dot) operator. 

namespace Lecture6Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentToList();
            Course csi122 = new Course("CSI 122", "Will Cram")

            //Display student from list
            //DisplayStudents();
        }

        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEd.Text);

            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);

            //add student to list
            students.Add(student);
        }
        public void DisplayStudents()
        {
            //clears display
            runDisplay.Text = "";
            for(int i = 0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";
            }
        }
      
    }
}
