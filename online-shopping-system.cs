using System;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
}

public class Order
{
    public DateTime Date { get; set; }
    public string Status { get; set; }

    public float CalcSubTotal()
    {
        // Calculation logic for sub-total
        return 0.0f;
    }

    public float CalcTax()
    {
        // Calculation logic for tax
        return 0.0f;
    }

    public float CalcTotal()
    {
        // Calculation logic for total
        return 0.0f;
    }

    public float CalcTotalWeight()
    {
        // Calculation logic for total weight
        return 0.0f;
    }
}

public class Payment
{
    public float Amount { get; set; }
}

public class Cash : Payment
{
    public float CashTendered { get; set; }
}

public class Check : Payment
{
    public string Name { get; set; }
    public string BankID { get; set; }

    public bool Authorized()
    {
        // Authorization logic for the check
        return false;
    }
}

public class Credit : Payment
{
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime ExpDate { get; set; }

    public bool Authorized()
    {
        // Authorization logic for the credit card
        return false;
    }
}

public class OrderDetail
{
    public LineItem LineItem { get; set; }
    public int Quantity { get; set; }
    public string TaxStatus { get; set; }

    public float CalcSubTotal()
    {
        // Calculation logic for sub-total
        return 0.0f;
    }

    public float CalcWeight()
    {
        // Calculation logic for weight
        return 0.0f;
    }

    public float CalcTax()
    {
        // Calculation logic for tax
        return 0.0f;
    }
}

public class Item
{
    public float ShippingWeight { get; set; }
    public string Description { get; set; }

    public float GetPriceForQuantity()
    {
        // Get price logic based on quantity
        return 0.0f;
    }

    public float GetTax()
    {
        // Get tax logic for the item
        return 0.0f;
    }

    public bool InStock()
    {
        // Check if the item is in stock
        return false;
    }
}
