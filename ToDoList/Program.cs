using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("How many things do you have to do?");

      int userInput = int.Parse(Console.ReadLine());

      for (int i = 0; i < userInput; i++)
      {
        Console.WriteLine("Enter the item to do! ");
        Item newItem = new Item(Console.ReadLine());
      }

      List<Item> result = Item.GetAll();
      Console.WriteLine("--------------------------");
      Console.WriteLine("Here's what you have to do!");
      foreach (Item thisItem in result)
      {
        Console.WriteLine(thisItem.Description);
      }
    }
  }
}