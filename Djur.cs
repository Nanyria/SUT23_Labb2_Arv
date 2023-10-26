using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Labb2_Arv
{
    internal class Djur
    {
        public string _name;
        public int _age;
        public string _description;
        public string _eyecolor;
        public string _typeOfAnimal;

        public Djur(string Name, int Age, string Description, string Eyecolor, string TypeOfAnimal)
        {
            _name = Name;
            _age = Age;
            _description = Description;
            _eyecolor = Eyecolor;
            _typeOfAnimal = TypeOfAnimal;
        }

        public virtual void makeSound()
        {

        }
        public virtual void AnimalInfo()
        {

        }
    }
}
