using System;

namespace Midterm_Project
{
        public enum StudentClass {
        Freshman,
        Sophmore,
        Junior,
        Senior
    }
    class Student : Person
    {
        private string major;
        private int creditHours;
        public Student(string firstName, string lastName, string id, string maj, int credit) : base(firstName, lastName, id, Category.Student) {
            major = maj;
            creditHours = credit;
        }

        public int getCreditHours() {
            return creditHours;
        }
        public void updateCreditHours(int hours) {
            creditHours += hours;
        }
        public StudentClass getStudentClass() {
            if (creditHours > 0 && creditHours < 30) {
                return StudentClass.Freshman;
            } else if(creditHours < 60) {
                return StudentClass.Sophmore;
            } else if(creditHours < 90) {
                return StudentClass.Junior;
            } else {
                return StudentClass.Senior;
            }
        }
    }
}
