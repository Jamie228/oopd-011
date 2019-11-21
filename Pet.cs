using System;
using System.Threading;

namespace oopd_011
{
    class Pet
    {
        Random rnd = new Random();
        private readonly PetType petType;
        private Mood mood;
        public string PetName { get; }

        int health;
        
        public Pet(PetType petType, string petName, Mood mood)
        {
            this.petType = petType;
            PetName = petName;
            health = 100;
            this.mood = mood;
            
        }

        public void Update()
        {
            
        }

        public void DisplayPet()
        {
            Console.WriteLine(PetName + " the " + Convert.ToString(petType));
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Mood: {mood}");
            MoodDecision();
            MoodDecision();
            MoodDecision();
            MoodDecision();

        }

        public void PetMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.   Shop");
            Console.WriteLine("2.   Inventory");
            Console.WriteLine("3.   Quit");
        }

        public void MoodDecision()
        {
            int moodChance = rnd.Next(1,101);

            if (moodChance >= 1 && moodChance < 34)
            {
                mood = Mood.Happy;
                DisplayMood();
            }
            else if (moodChance >= 34 && moodChance < 67)
            {
                mood = Mood.Sad;
                DisplayMood();
            }
            else if (moodChance >= 67 && moodChance < 101)
            {
                mood = Mood.Bored;
                DisplayMood();
            }

        }

        public void DisplayMood()
        {
            Console.WriteLine($"{PetName} is feeling {mood}");
        }
        public void Play()
        {

        }

        public void Illness()
        {

        }
    }
}