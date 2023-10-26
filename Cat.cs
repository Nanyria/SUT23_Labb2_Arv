using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb2_Arv
{
    internal class Cat : Animal
    {
        public string _color;

        public Cat(string Name, int Age, string Description, string Diet, string TypeOfAnimal, bool ifWild, string Color) : base(Name, Age, Description, Diet, TypeOfAnimal, ifWild)
        {
            _color = Color;
        }
    }
}
