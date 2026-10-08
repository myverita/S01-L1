using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CombatenteDeGondor
{
    public string Nome { get; private set; }
    public string Povo { get; private set; }
    public string Posto { get; private set; }

    public string Armamento { get; private set; } = "Desarmado";

    public CombatenteDeGondor(string nome, string povo, string posto)
    {
        this.Nome = nome;
        this.Povo = povo;
        this.Posto = posto;
    }

    public void Equipar(string arma)
    {
        this.Armamento = arma;
    }

    public void ApresentarUnidade()
    {
        Console.WriteLine("\nCombatente de Gondor");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Povo: {Povo}");
        Console.WriteLine($"Posto: {Posto}");

        if (Armamento != "Desarmado")
        {
            Console.WriteLine($"Armamento: {Armamento}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        CombatenteDeGondor combatente1 =
            new CombatenteDeGondor("legolas", "paulistas", "capitão");

        CombatenteDeGondor combatente2 =
            new CombatenteDeGondor("sam", "goianos", "soldado");

        CombatenteDeGondor combatente3 =
            new CombatenteDeGondor("gandalf", "sulistas", "mago");

        combatente1.Equipar("arco");

        // tentativa de alterar o posto diretamente (erro pq posto possui private set)
        //combatente2.Posto = "Capitão";

        combatente1.ApresentarUnidade();
        combatente2.ApresentarUnidade();
        combatente3.ApresentarUnidade();

    }
}
