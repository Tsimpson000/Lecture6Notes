using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Notes
{
    public class Student
    {
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public double StudentAverage()
        {
            return (_csiGrade + _genEdGrade / 2);
        }
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName} - CSI grade {this._csiGrade} - GenEd Grade {this._genEdGrade} - Average {StudentAverage()}";
        }
    }
}
