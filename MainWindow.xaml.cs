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

//Review: What’s the name for any field, constructor, property or method that is part of a class?
//Review: What are the 4 parts of declaring a method?
//What keyword allows you to access members related to the specific instance?
//A method build inside a class has access to what, even it’s access modifier is set to private?
//What does “override .ToString()” allow us to do?
//You use the *____ operator* do you use to access members inside of an instanced class?

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
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEd.Text);

            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);

            //add student to list
            students.Add(student);

            //Display student from list
            runDisplay.Text = students[0].FirstName;
        }
    }
}
