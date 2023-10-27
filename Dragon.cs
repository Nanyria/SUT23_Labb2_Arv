﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb2_Arv
{
    internal class Dragon : Animal
    {
        public int _numberofSightings;

        public Dragon() : this("No name provided", 00, "No info", "No info", 00)
        {

        }
        public Dragon(string Name, int Age, string Diet, string Color, int NumberOfSightings) : base(Name, Age, Diet, Color)
        {
            _numberofSightings = NumberOfSightings;
            _ifWild = true;
        }
        public override void makeSound()
        {
            Console.WriteLine("The sound dragons make differs depending of type of dragon.\nSome dragons are even capable of communicating with humans.");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("\n DRAGON\nName: {0}. \nAge:{1}.\nPreferred diet: {2}.\nColor: {3}\nNumber of legs: {4}\nAll dragons are wild.", _name, _age, _diet, _color, _numberofSightings);
            _ifWild = true;
        }
        public override void Hunting()
        {
            Console.WriteLine("Dragons generally hunt by attacking their pray from the air.");
        }
        public void DragonWyvern()
        {
            if(_numberofSightings == 2)
            {
                
            }

        }

    }
    internal class Wyvern : Dragon
    {
        public string _colorOfFire;

        public Wyvern(string Name, int Age, string Diet, string Color, int NumberOfSightings, string ColorOfFire) : base(Name, Age, Diet, Color, NumberOfSightings)
        {
            _colorOfFire = ColorOfFire;

        }
        public override void AnimalInfo()
        {
            base.AnimalInfo();
            Console.WriteLine("Wyverns breathe fire, the color of this Wyvern's fire is {0}.", _colorOfFire);
        }
        public override void Hunting()
        {
            Console.WriteLine("Wyverns hunt by attacking their pray from the air, scorching them to death and then devours the charred remains");
        }

    }
    internal class WesternDragon : Dragon
    {
        public bool _humanSpeach;
        public WesternDragon(string Name, int Age, string Diet, string Color, int NumberOfSightings, bool HumanSpeach) : base(Name, Age, Diet, Color, NumberOfSightings)
        {
            _humanSpeach = HumanSpeach;
        }
        public override void AnimalInfo()
        {
            base.AnimalInfo();
            if (_humanSpeach)
            {
                Console.WriteLine("This dragon is capable of communicating with humans.");
            }
            else
            {
                Console.WriteLine("This dragon is not capable of communicating with humans.");
            }

        }
        public override void Hunting()
        {
            Console.WriteLine("Western dragons hunt by attacking their pray from the air, blasting them with acid and then gulping up the sloshed remains.");
        }
    }

}
