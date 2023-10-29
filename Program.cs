namespace SUT23_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InfoProvided();


            Console.ReadKey();
        }
        public static void InfoProvided()
        {

            Cat cat = new Cat("Arnold", 2, "Kibbles", "Red", false, true);
            Dog dog = new Dog("Ben", 6, "Treats", "Black", true, "Unknown");
            Dog dog2 = new Dog("Alice", 4, "Any meat", "Purple", false, "Poodle");
            Dragon dragon = new Dragon("Ara", 367, "Sheep", "Red", 56);
            Wyvern wyvern = new Wyvern("Bob", 422, "Mice", "Green", 2, "Yellow");
            WesternDragon westernDragon = new WesternDragon("Garanoff", 65, "Peasants", "Gold", 734, true);

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
            Cat cat = new Cat("Arnold", 2, "Kibbles", "Red", false, true);
            Dog dog = new Dog("Ben", 6, "Treats", "Black", true, "Unknown");
            Dog dog2 = new Dog("Alice", 4, "Any meat", "Purple", false, "Poodle");
            Dragon dragon = new Dragon("Ara", 367, "Sheep", "Red", 56);
            Wyvern wyvern = new Wyvern("Bob", 422, "Mice", "Green", 2, "Yellow");
            WesternDragon westernDragon = new WesternDragon("Garanoff", 65, "Peasants", "Gold", 734, true);

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