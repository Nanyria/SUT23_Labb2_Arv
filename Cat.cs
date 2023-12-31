﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SUT23_Labb2_Arv
{
    internal class Cat : Animal
    {
        public bool _ifLonghaired;

        public Cat() : this("No name provided", 00, "No info", "No info", "No info", null, false)
        {

        }
        public Cat(string Name, int Age, string Diet, string Color, string Location, bool? ifWild, bool IfLongHaired) : base(Name, Age, Diet, Color, Location)
        {
            _ifWild = ifWild;
            _ifLonghaired = IfLongHaired;
        }
        public override void makeSound()
        {
            Console.WriteLine("The sound cats make is 'Meow'.");
        }
        public override void AnimalInfo()
        {
            Console.WriteLine("\n CAT\nName: {0}. \nAge: {1}.\nPreferred diet: {2}.\nColor: {3}\nLocation: {4}", _name, _age, _diet, _color, _location);
            if (_ifWild.HasValue)
            {
                if (_ifWild.Value)
                {
                    Console.WriteLine("This cat is wild.");
                }
                else
                {
                    Console.WriteLine("This cat is tame.");
                }
            }
            else
            {
                Console.WriteLine("This cat has not been specified as wild or tame");
            }
            Fur();
        }

        public override void Hunting()
        {
            if (_ifWild.HasValue)
            {
                if (_ifWild.Value)
                {
                    Console.WriteLine("Wild cats hunt smaller pray, for example rats, mice and birds.");
                }
                else
                {
                    Console.WriteLine("While tame cats usually do not need to hunt, \nthey relish the opportunity and will often provide their owners with 'gifts' such as dead mice or birds.");
                }
            }
            else
            {
                Console.WriteLine("This cat has not been specified as wild or tame, as such there is not enough information to provide hunting info.");
            }
        }
        public void Fur()
        {
            if( _ifLonghaired) 
            {
                Console.WriteLine("Cats with longer furr require help with grooming as to avoid tangles and an excess of hairballs.");
            }
            else
            {
                Console.WriteLine("Cats with shorter furr manage their furr themselves for the most part, \nbut may need help grooming while shedding.");
            }
        }
    }
}
