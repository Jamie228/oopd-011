using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopd_011
{
    public enum TempStat
    {
        Cold,
        Hot,
        OK
    }
    class Pet
    {
        private readonly PetType petType;
        public string PetName { get; }
        int mood;
        int hunger;
        int health;
        public double idealTemp;
        TempStat tempStat;
        
        
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
            Console.WriteLine($"{PetName} is {tempStat}");
        }

        public void Update()
        {

            if (hunger > 50)
            {
                health --;
            }
            
            if (hunger + 1 <= 100)
            {
                hunger ++;
            }
            
            if (mood - 1 >= 0)
            {
                mood--;
            }
        }

        public void UpdatePetTemp(Room room)
        {
            if (room.temp > idealTemp + 2.0)
            {
                tempStat = TempStat.Hot;
                health --;
            }
            else if (room.temp < idealTemp - 2.0)
            {
                tempStat = TempStat.Cold;
                health --;
            }
            else
            {
                tempStat = TempStat.OK;
            }
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

        public void EatFood(Food food)
        {
            hunger -= food.hungerDec;
            health += 5;
            food.uses --;
        }

        public void TakeMedicine(Medicine med)
        {
            health += med.healthInc;
            hunger += med.hungerInc;
            med.uses --;
        }

        public void PlayWithToy(Toy toy)
        {
            mood += toy.moodInc;
            toy.uses --;   
        }
    }
}