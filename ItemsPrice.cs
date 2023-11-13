using System;

class ItemsPrice
{
    static void Main()
    {
        // Enter the price of three items
        Console.Write("Enter the price of first item: ");
        double item1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the price of second item: ");
        double item2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the price of third item: ");
        double item3 = Convert.ToDouble(Console.ReadLine());

        // Total price & Discount
        double totalPrice = item1 + item2 + item3;
        double netAmountPayable = totalPrice - (totalPrice * 0.1); // 10% Discount

        // Display netAmountPayable value
        Console.WriteLine("Net amount payable is: $" + netAmountPayable);
    }
}