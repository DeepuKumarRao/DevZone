

//class Program
//{
//    static void Main()
//    {
//        int amount = 1000;
//        int tenPercent = amount * 10 / 100;
//        int newTotal = amount + tenPercent;
//        int eighteenPercent = newTotal * 18 / 100;
//        int finalTotal = newTotal + eighteenPercent;

//        Console.WriteLine($"Original Amount: {amount}");
//        Console.WriteLine($"Add 10%: {tenPercent} (Total: {newTotal})");
//        Console.WriteLine($"Add 18% of new total: {eighteenPercent} (Final Total{finalTotal})");
//    }
//}

//Another way

class Calculate
{


    public static decimal AddPercent(decimal value, decimal percent)
    {
        return value + (value * percent / 100m);
    }

    static void Main()
    {
        decimal amount = 1000m;

        decimal after10 = AddPercent(amount, 10);
        decimal finalTotal = AddPercent(after10, 18);

        Console.WriteLine($"Final Total: {finalTotal}");
        Console.ReadLine();
    }
}

