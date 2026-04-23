
Console.WriteLine("Hi welcome to john whatevers bank, what may i get you:\n 1. Transfer\n 2. E-wallet\n 3. Credit Card");
string funny = Console.ReadLine();
switch (funny)
{
    case "1":
        Metode1 the_time = new Metode1();
        the_time.by_default(50000000);
        break;
    case "2":
        Metode2 the_time2 = new Metode2();
        the_time2.by_default(50000000);
        break;
    case "3":
        Metode3 the_time3 = new Metode3();
        the_time3.by_default(50000000);
        break;
}

class metodePembayaran
{
    public virtual void by_default(int amount)
    {
        Console.WriteLine("Default");
    }
}

class Metode1 : metodePembayaran
{
    public override void by_default(int amount)
    {
        Console.WriteLine($"MONEY TRANSFERRED BY: {amount} \n TO: 12345678");
        
    }
}
class Metode2 : metodePembayaran
{
    public override void by_default(int amount)
    {
        Console.WriteLine($"BALANCED DEDUCTED BY: {amount}");

    }
}
class Metode3 : metodePembayaran
{
    public override void by_default(int amount)
    {
        Console.WriteLine($"TRANSACTION OF RP: {amount} COMPLETED");

    }
}
