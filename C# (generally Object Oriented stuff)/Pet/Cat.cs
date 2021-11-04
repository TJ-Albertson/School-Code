using System;

namespace Pet
{
    class Cat : Pet
    {
        public Cat(string petName, string petOwner, double petWeight) : base("Cat", petName, petOwner, petWeight) {}

        public string meow(int count) {
            string meow = "";
            for(int i = 0; i < count; i++) {
                meow += "meow.";
            }
            return meow;
        }

    }
}
