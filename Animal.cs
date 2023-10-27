namespace SUT23_Labb2_Arv
{
    internal class Animal
    {
        public string _name;
        public int _age;
        public string _diet;
        public string _color;
        public bool _ifWild;

        public Animal() : this("No name provided", 00, "No info", "No info")
        {

        }

        public Animal(string Name, int Age, string Diet, string Color)
        {
            _name = Name;
            _age = Age;
            _diet = Diet;
            _color = Color;
        
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
