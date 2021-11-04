using System;

namespace Dog
{
    public enum Gender {
        Male,
        Female
    }

    public class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public Dog(string dogName, string dogOwner, int dogAge, Gender dogGender) {
            name = dogName;
            owner = dogOwner;
            age = dogAge;
            gender = dogGender;
        }

        public void Bark(int num) {
            for (int i = 0; i<num; i++) {
                Console.Write("Woof!");
            }
            Console.Write("\n");
        }

        public string GetTag() {
            
            string herHis = "";
            string sheHe = "";
            string yearYears = "";

            if (gender == Gender.Male) {
                herHis = "his";
                sheHe = "he";
            } else {
                herHis = "her";
                sheHe = "she";
            }

            if(age == 1){
                yearYears = "year";
            } else {
                yearYears = "years";
            }

            return "if lost, call "+owner+". "+herHis+" name is "+name+" and and "+sheHe+" is "+age+" "+yearYears+" old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
}
