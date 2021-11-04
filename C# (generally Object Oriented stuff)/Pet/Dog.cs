using System;

namespace Pet
{
    class Dog : Pet
    {
        public Dog(string petName, string petOwner, double petWeight) : base("Dog", petName, petOwner, petWeight) {}

        public string bark(int count) {
            string bark = "";
            for(int i = 0; i < count; i++) {
                bark += "bark!";
            }
            return bark;
        }

    }
}
