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
        
        public Pet(PetType petType, string petName)
        {
            this.petType = petType;
            PetName = petName;
            health = 100;
            mood = 75;
            hunger = 0;
            
        }

        public void Update()
        {
            
        }

        public void DisplayPet()
        {
            Console.WriteLine(PetName + " the " + Convert.ToString(petType));
            Console.WriteLine($"Health: {health}");

        }

        public void PetMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.   Shop");
            Console.WriteLine("2.   Play With Pet");
            Console.WriteLine("3.   Feed Pet");
            Console.WriteLine("4.   Quit");
        }

        public void Play()
        {

        }

        public void Illness()
        {

        }
    }
}