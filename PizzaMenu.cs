using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        PizzaMenuClass.ShowMenu();
    }
}
 public class PizzaMenuClass
 {
     public static void ShowMenu()
     {
        Console.WriteLine("Welcome to the Pizza shop!");
        Console.WriteLine("1. Cheese - $8 \n2. Vegetarian - $9 \n3.  Pepperoni - $10 \n4. Supreme - $11 \n5. Hawaiian - $12 \n6. BBQ Chicken - $13 \n7. Meat Lovers - $14 ");
        Thread.Sleep(2000);

        Console.WriteLine("Choose a number:");
        var num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Size: \n(small/medium/large)");
        var size = Console.ReadLine().ToLower();

        var price = 0;
        var pizza = "";

        if (num == 1)
        {
            pizza = "Cheese";
            price = 8;
        }
        else if (num == 2)
        {
            pizza = "Vegetarian";
            price = 9;
        }
        else if (num == 3)
        {
            pizza = "Pepperoni";
            price = 10;
        }
        else if (num == 4)
        {
            pizza = "Supreme";
            price = 11;
        }
        else if (num == 5)
        {
            pizza = "Hawaiian";
            price = 12;
        }
        else if (num == 6)
        {
            pizza = "BBQ Chicken";
            price = 13;
        }
        else if (num == 7)
        {
            pizza = "Meat Lovers";
            price = 14;
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            return;
        }
        if (size == "medium")
        {
            price = price + 2;
        }
        else if (size == "large")
        {
            price = price + 4;
        }
        else if (size == "small")
        {
            price = price + 0;
        }
        else if (size != "")
        {
            Console.WriteLine("Invalid size!");
            return;
        }
        Console.WriteLine("You ordered " + pizza + "(" + size + ")" + "Total:$ " + price);

        if (price >= 15)
        {
            Console.WriteLine("Free drink!");
        }
     }
 }
