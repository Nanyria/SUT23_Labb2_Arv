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

        public Dog() : this("No name provided", 00, "No info", "No info", "No info", null, "No info")
        {

        }
        public Dog(string Name, int Age, string Diet, string Color, string Location, bool? ifWild, string Breed) : base(Name, Age, Diet, Color, Location)
        {
            _ifWild = ifWild;
            _breed = Breed;
        }
        public override void makeSound()
        {
            Console.WriteLine("The sound dogs make is 'Woff'.");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("\n DOG\nName: {0}. \nAge: {1}.\nPreferred diet: {2}.\nColor: {3}\nLocation: {4}\nBreed: {5}", _name, _age, _diet, _color, _location, _breed);
            if (_ifWild.HasValue)
            {
                if (_ifWild.Value)
                {
                    Console.WriteLine("This dog is wild.");
                }
                else
                {
                    Console.WriteLine("This dog is tame.");
                }
            }
            else
            {
                Console.WriteLine("This dog has not been specified as wild or tame");
            }
            Training();
        }
        public override void Hunting()
        {
            if (_ifWild.HasValue)
            {
                if (_ifWild.Value)
                {
                    Console.WriteLine("Wild dogs hund smaller pray, the pray itself differs depending on what breed of dog it is.");
                }
                else
                {
                    Console.WriteLine("While tame dogs do not need to hunt, many species are used as a help for hunters.");
                }
            }
            else
            {
                Console.WriteLine("This dog has not been specified as wild or tame");
            }
        }
        public void Training()
        {
            if (_ifWild.HasValue)
            {
                if (_ifWild.Value)
                {
                    Console.WriteLine("It is not recommended to train wild dogs. Since they are wild.");
                }
                else
                {
                    Console.WriteLine("For tame dogs, training is crucial, \nit is recommended to start training obedience and leash-training while they're still pups.");
                }
            }
            else
            {
                Console.WriteLine("This dog has not been specified as wild or tame, as such it is unknown weather this dog is trainable.");
            }

        }
    }
}
