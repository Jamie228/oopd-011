using System;
using System.Threading;

namespace oopd_011
{
    class Pet
    {
        private readonly PetType petType;
        public string PetName { get; }

        int health;
        int mood;
        
        public Pet(PetType petType, string petName)
        {
            this.petType = petType;
            PetName = petName;
            health = 100;
            mood = 100;
        }

        public void Update()
        {
            
        }

        public void DisplayPet()
        {
            Console.WriteLine(PetName + " the " + Convert.ToString(petType));
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Mood: {mood}");
        }

        public void PetMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.   Shop");
            Console.WriteLine("2.   Inventory");
            Console.WriteLine("3.   Quit");
        }

        public void Play()
        {

        }

        public void Illness()
        {

        }
    }
}