using System;

namespace Midterm_Project
{
    public enum Category {
        Student,
        Faculty,
        Staff
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private string id;
        private Category category;

        public Person(string first, string last, string ident, Category cat)  {
            firstName = first;
            lastName = last;
            id = ident;
            category = cat;
        }


        public void getPersonInfo() {
            Console.WriteLine("Name: {0} {1}\nID: {2}\nType:{3}", firstName, lastName, id, category);
        }


        public string getFirstName() {
            return firstName;
        }
        public void setFirstName(string name) {
            firstName = name;
        }

        public string getLastName() {
            return lastName;
        }
        public void setLastName(string name) {
            lastName = name;
        }

        public Category getCategory() {
            return category;
        }
        public void setCategory(Category cat) {
            category = cat;
        }

        public string getID() {
            return id;
        }
    }
}
