namespace SUT23_Labb2_Arv
{
    internal class Animal
    {
        public string _name;
        public int _age;
        public string _diet;
        public string _color;
        public bool _ifWild;

        public Animal(string Name, int Age, string Diet, string Color, bool IfWild)
        {
            _name = Name;
            _age = Age;
            _diet = Diet;
            _color = Color;
            _ifWild = IfWild;
        }

        public virtual void makeSound()
        {

        }
        public virtual void AnimalInfo()
        {

        }
        public virtual void Hunting()
        {

        }
    }
}
