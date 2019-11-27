using System;
using System.Threading;

namespace oopd_011
{
    class Pet
    {
        private readonly PetType petType;
        public string PetName { get; }
        int mood;
        int hunger;
        int health;
        public double idealTemp;
        
        public Pet(PetType petType, string petName)
        {
            this.petType = petType;
            PetName = petName;
            health = 100;
            mood = 75;
            hunger = 0;
            idealTemp = 22.5;
            
        }

        public void DisplayPet()
        {
            Console.WriteLine(PetName + " the " + Convert.ToString(petType));
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Mood: {mood}");
            Console.WriteLine($"Hunger: {hunger}");

        }

        public void PetMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.   Shop");
            Console.WriteLine("2.   Use Item");
            Console.WriteLine("3.   Heat Room");
            Console.WriteLine("4.   Cool Room");
            Console.WriteLine("5.   Quit");
        }

        public void Play()
        {

        }

        public void Illness()
        {

        }
    }
}