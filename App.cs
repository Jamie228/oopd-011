using System;

namespace oopd_011
{
    class App
    {
        int userPetChoice;
        string userPetName;
        ItemList itemlist = new ItemList();
        Inventory inventory = new Inventory();
        public void InitApp()
        {
            itemlist.CreateItemList();
            itemlist.PrintShopList();
            PetSelect();
        }

        public void Run()
        {
            
        }
        public void PetSelect()
        {
            Console.WriteLine("Choose a pet: ");
            Console.WriteLine("1.   Dog");
            Console.WriteLine("2.   Cat");
            Console.WriteLine("3.   Tortoise");
            userPetChoice = Convert.ToInt32(Console.ReadLine());

            if (userPetChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Dog, userPetName);
                pet.DisplayPet();
            }
            else if (userPetChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Cat, userPetName);
                pet.DisplayPet();
            }
            else if (userPetChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Tortoise, userPetName);
                pet.DisplayPet();
            }

        }
    }
}