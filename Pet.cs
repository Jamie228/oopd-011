using System;

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

        public void DisplayPet()
        {
            Console.WriteLine(PetName + " the " + Convert.ToString(petType));
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Mood: {mood}");
        }

        public void Play()
        {

        }

        public void Illness()
        {

        }
    }
}