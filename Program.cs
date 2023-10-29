namespace SUT23_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInfoProvided();


            Console.ReadKey();
        }
        public static void InfoProvided()
        {

            Cat cat = new Cat("Arnold", 2, "Kibbles", "Red","London", false, true);
            Dog dog = new Dog("Ben", 6, "Treats", "Black", "Uppsala", true, "Unknown");
            Dog dog2 = new Dog("Alice", 4, "Any meat", "Purple", "Sofia", false, "Poodle");
            Dragon dragon = new Dragon("Ara", 367, "Sheep", "Red", "Alingsås", 56);
            Wyvern wyvern = new Wyvern("Bob", 422, "Mice", "Green","Camelot", 2, "Yellow");
            WesternDragon westernDragon = new WesternDragon("Garanoff", 65, "Peasants", "Gold", "Westeros", 734, true);

            Animal[] animals = { cat, dog, dog2, dragon, wyvern, westernDragon };
            foreach (Animal item in animals)
            {
                item.AnimalInfo();
                item.makeSound();
                item.Hunting();
            }

        }
        public static void NoInfoProvided()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Dog dog2 = new Dog();
            Dragon dragon = new Dragon();
            Wyvern wyvern = new Wyvern();
            WesternDragon westernDragon = new WesternDragon();

            Animal[] animals = { cat, dog, dog2, dragon, wyvern, westernDragon };
            foreach (Animal item in animals)
            {
                item.AnimalInfo();
                item.makeSound();
                item.Hunting();
            }

        }
    }
}