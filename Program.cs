using System.Globalization;

class Progam
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o codigo do produto:");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade!!");
        int quantidade = int.Parse(Console.ReadLine());

        double total;
        if (codigo == 1)
        {
            total = quantidade * 4.0;
        }
        else if (codigo == 2)
        {
            total = quantidade * 4.5;
        }
        else if (codigo == 3)
        {
            total = quantidade * 5.0;
        }
        else if (codigo == 4)
        {
            total = quantidade * 2.0;
        }
        else
        {
            total = quantidade * 1.5;
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }
}