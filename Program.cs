namespace SUT23_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Arnold", 2, "Kibbles", "Red", false, true);
            Dog dog = new Dog("Ben", 6, "Treats", "Black", true, "Unknown");
            Dog dog2 = new Dog("Alice", 4, "Any meat", "Purple", false, "Poodle");
            Dragon dragon = new Dragon("Ara", 367, "Sheep", "Red", 56);

            Animal[] animals = { cat, dog, dog2, dragon };
            foreach ( Animal item in animals)
            {
                item.AnimalInfo();
                item.makeSound();
                item.Hunting();
            }

            Console.ReadKey();
        }
    }
}