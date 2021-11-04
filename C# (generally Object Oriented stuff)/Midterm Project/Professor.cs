using System;

namespace Midterm_Project
{
    class Professor : Person
    {
        private string department;
        private string researchArea;
        public Professor(string firstName, string lastName, string id, string depart, string research) : base(firstName, lastName, id, Category.Faculty) {
            department = depart;
            researchArea = research;
        }

        public string getDepartment() {
            return department;
        }
        public void setDepartment(string str) {
            department = str;
        }

        public string getResearchArea() {
            return researchArea;
        }
        public void setResearchArea(string research) {
            researchArea = research;
        }
    }
}
