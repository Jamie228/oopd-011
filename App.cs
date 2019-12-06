using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
        public enum AppState
        {
            Run,
            Shop,
            Food,
            Medicine,
            Toys,
            Pause,
            Exiting
        }
    class App
    {
        AppState appState = AppState.Run;
        int userPetChoice;
        string userPetName;
        Shop shop = new Shop();
        Player player = new Player(100);
        public Room room = new Room(18.0);
        Pet pet;
        public App()
        {
            
        }

        public void Initialise()
        {
            Console.CursorVisible = false;
            Console.Clear();
            pet = PetSelect();
        }

        public void Run()
        {
            Initialise();

            do
            {
                CheckKeyInput();

                switch (appState)
                {
                    case AppState.Run:
                        Console.Clear();
                        player.Update();
                        player.DisplayCoins();
                        room.UpdateTemp();
                        pet.UpdatePetTemp(room);
                        pet.Update();
                        pet.DisplayPet();
                        Console.WriteLine("---------------");
                        DrawMainMenu();
                        break;
                    case AppState.Pause:
                        break;
                    case AppState.Shop:
                        Console.Clear();
                        pet.Update();
                        pet.DisplayPet();
                        DrawMainMenu();
                        Console.WriteLine();
                        shop.PrintShopList(player);
                        appState = AppState.Run;
                        break;
                    case AppState.Food:
                        player.inventory.DisplayFood(pet);
                        break;
                    case AppState.Medicine:
                        player.inventory.DisplayMedicine(pet);
                        break;
                    case AppState.Toys:
                        player.inventory.DisplayToys(pet);
                        break;
                    case AppState.Exiting:
                        break;
                    default:
                        break;
                }
                
                
                Thread.Sleep(10000/10);
            } while (appState != AppState.Exiting);
        }
        public Pet PetSelect()
        {
            Console.WriteLine("Choose a pet: ");
            Console.WriteLine("1.   Dog");
            Console.WriteLine("2.   Cat");
            Console.WriteLine("3.   Tortoise");
            Console.WriteLine("4.   Raccoon");
            userPetChoice = Convert.ToInt32(Console.ReadLine());

            if (userPetChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Dog, userPetName);
                return(pet);
            }
            else if (userPetChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Cat, userPetName);
                return(pet);
            }
            else if (userPetChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Tortoise, userPetName);
                return(pet);
            }
            else if (userPetChoice == 4)
            {
                Console.Clear();
                Console.WriteLine("Enter a name: ");
                userPetName = Console.ReadLine();
                Console.Clear();
                Pet pet = new Pet(PetType.Raccoon, userPetName);
                return(pet);
            }
            else
            {
                return null;
            }

        }

        public void CheckKeyInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Escape)
                {
                    appState = AppState.Exiting;
                }

                if (keyPressed == ConsoleKey.F)
                {
                    appState = AppState.Food;
                }

                if (keyPressed == ConsoleKey.T)
                {
                    appState = AppState.Toys;
                }

                if (keyPressed == ConsoleKey.M)
                {
                    appState = AppState.Medicine;
                }

                if (keyPressed == ConsoleKey.S)
                {
                    appState = AppState.Shop;
                }


                if (keyPressed == ConsoleKey.P)
                {
                    if (appState != AppState.Pause)
                    {
                        appState = AppState.Pause;
                    }
                    else if (appState == AppState.Pause)
                    {
                        appState = AppState.Run;
                    }

                }

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    room.HeatRoom();
                }

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    room.CoolRoom();
                }
            }
        }

        public void DrawMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("S:   Shop");
            Console.WriteLine("F:   Feed Pet");
            Console.WriteLine("T:   Play With Pet");
            Console.WriteLine("M:   Give Medicine");
            Console.WriteLine("P:   Pause");
            Console.WriteLine("UP:  Heat Room");
            Console.WriteLine("DWN: Cool Room");
            Console.WriteLine("ESC: Exit");
        }
    }
}