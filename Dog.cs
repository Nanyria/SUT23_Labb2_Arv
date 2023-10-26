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

        public Dog(string Name, int Age, string Description, string Diet, string TypeOfAnimal, bool ifWild, string Breed) : base(Name, Age, Description, Diet, TypeOfAnimal, ifWild)
        {
            _breed = Breed;
        }
    }
}
