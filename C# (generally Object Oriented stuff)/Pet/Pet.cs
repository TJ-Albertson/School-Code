using System;

namespace Pet
{
    public class Pet
    {
        private string type;
        private string name;
        private string owner;
        private double weight;

        public Pet(string petType, string petName, string petOwner, double petWeight) {
            type = petType;
            name = petName;
            owner = petOwner;
            weight = petWeight;
        }

        public string getTag() {
            string tag = "If lost, call " + owner;
            return tag;   
        }

        public string getName() {
            return name;
        }

        public string getType(){
            return type;
        }

        public string getOwner() {
            return owner;
        }

        public void setOwner(string newOwner) {
            owner = newOwner;
        }

        public double getWeight() {
            return weight;
        }
        
        public void setWeight(double newWeight) {
            weight = newWeight;
        }
    }
}
