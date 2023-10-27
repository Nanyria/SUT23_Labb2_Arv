using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb2_Arv
{
    internal class Dog : Animal
    {
        public string _breed;

        public Dog(string Name, int Age, string Diet, string Color, bool ifWild, string Breed) : base(Name, Age, Diet, Color, ifWild)
        {
            _breed = Breed;
        }
        public override void makeSound()
        {
            Console.WriteLine("The sound dogs make is 'Woff'.");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("\n DOG\nName: {0}. \nAge:{1}.\nPreferred diet: {2}.\nColor: {3}\nBreed: {4}", _name, _age, _diet, _color, _breed);
            if (_ifWild)
            {
                Console.WriteLine("This dog is wild.");
            }
            else
            {
                Console.WriteLine("This dog is tame.");
            }
        }
        public override void Hunting()
        {

        }
        public void Training()
        {

        }
    }
}
