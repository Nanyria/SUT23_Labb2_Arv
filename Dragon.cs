using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb2_Arv
{
    internal class Dragon : Animal
    {
        public int _numberofLegs;

        public Dragon(string Name, int Age, string Description, string Diet, string TypeOfAnimal, bool ifWild, int NumberOfLegs) : base(Name, Age, Description, Diet, TypeOfAnimal, ifWild)
        {
            _numberofLegs = NumberOfLegs;
        }
    }
}
