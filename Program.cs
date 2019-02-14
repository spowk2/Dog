using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogChallenge
{
    enum Gender { Male, Female };

    class Dog
    {
        public Dog(String nameC, String ownerC, int ageC, Gender genderC)
        {
            name = nameC;
            owner = ownerC;
            age = ageC;
            gender = genderC;
        }
        public String name;
        public String owner;
        public int age;
        public Gender gender;

        public void bark(int barks)
        {
            for (int i = 0; i < barks; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public String getTag()
        {
            String tag = "";
            if (gender == Gender.Male && age <= 1)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " year old.";
            }
            else if (gender == Gender.Male && age > 1)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old.";
            }
            else if (gender == Gender.Female && age <= 1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " year old.";
            }
            else if (gender == Gender.Female && age > 1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.";
            }

            return tag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
            Console.ReadLine();
        }
    }
}