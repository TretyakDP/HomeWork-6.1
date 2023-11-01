using System;

public class Soda
{
    private string flavor;

    public Soda(string flavor = null)
    {
        this.flavor = flavor;
    }

    public string GetDescription()
    {
        if (!string.IsNullOrEmpty(flavor))
        {
            return $"У вас газировка с {flavor} вкусом";
        }
        else
        {
            return "У вас обычная газировка";
        }
    }
}

class Program
{
    static void Main()
    {
        Soda sodaWithFlavor = new Soda("клубничным");
        Console.WriteLine(sodaWithFlavor.GetDescription()); // Вывод: "У вас газировка с клубничным вкусом"

        Soda plainSoda = new Soda();
        Console.WriteLine(plainSoda.GetDescription()); // Вывод: "У вас обычная газировка"
    }
}
