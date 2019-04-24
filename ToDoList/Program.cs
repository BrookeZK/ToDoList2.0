using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("-----------------------");
      while(true) {
        Console.WriteLine("Would you like to add an item to your list, view your list or quit? (Add/View/Quit)");
        string userChoice = Console.ReadLine();
        string lowerUserChoice = userChoice.ToLower();
        if (lowerUserChoice == "add")
        {
          string chore = "";
          while(true) {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please enter a description of the task you would like to add to the To Do List:");
            Console.WriteLine("'main menu' to return to Main Menu,  'view' to see list");
            chore = Console.ReadLine();
            if(chore == "view")
            {
              Console.WriteLine("-----------------------");
              Console.WriteLine("Your To Do List: ");
              Item.WriteToConsole();
              break;
            }
            else if (chore == "main menu")
            {
              break;
            }
            Item newItem = new Item(chore);
            Console.WriteLine("'" + chore + "'" + " has been added to your To Do List.");
          }
        }
        else if (lowerUserChoice == "view")
        {
          Console.WriteLine("-----------------------");
          Console.WriteLine("Your To Do List: ");
          Item.WriteToConsole();
        }
        else if (lowerUserChoice == "quit")
        {
          break;
        }
      }
    }
  }
}
