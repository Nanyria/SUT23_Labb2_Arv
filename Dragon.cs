using System;
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
        public int _numberofLegs;

        public Dragon(string Name, int Age, string Diet, string Color, bool ifWild, int NumberOfLegs) : base(Name, Age, Diet, Color, ifWild)
        {
            _numberofLegs = NumberOfLegs;
        }
        public override void makeSound()
        {
            Console.WriteLine("The sound dragons make has not been recorded since there have been no survivors to tell the tale.");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("\n DRAGON\nName: {0}. \nAge:{1}.\nPreferred diet: {2}.\nColor: {3}\nNumber of legs: {4}", _name, _age, _diet, _color, _numberofLegs);
            _ifWild = true;
        }
        public override void Hunting()
        {
            Console.WriteLine("Dragons generally hunt by attacking their pray from the air.");
        }
        public void DragonWyvern()
        {
            if(_numberofLegs == 2)
            {
                
            }

        }

    }
    internal class Wyvern : Dragon
    {
        public string _firebreather;

        public Wyvern(string Name, int Age, string Description, string Diet, string TypeOfAnimal, bool ifWild, int NumberOfLegs, string Firebreather) : base(Name, Age, Diet, TypeOfAnimal, ifWild, NumberOfLegs)
        {
            _firebreather = Firebreather;


        }
        public override void Hunting()
        {
            Console.WriteLine("Wyverns hunt by attacking their pray from the air, scorching them to death and then devours the charred remains");
        }

    }
    internal class WesternDragon : Dragon
    {
        public string _poisonous;
        public WesternDragon(string Name, int Age, string Description, string Diet, string TypeOfAnimal, bool ifWild, int NumberOfLegs, string Poisonous) : base(Name, Age, Diet, TypeOfAnimal, ifWild, NumberOfLegs)
        {
            _poisonous = Poisonous;
        }
        public override void Hunting()
        {
            Console.WriteLine("Western dragons hunt by attacking their pray from the air, blasting them with acid and then gulping up the sloshed remains.");
        }
    }

}
