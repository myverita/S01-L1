using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EntidadeCosmica
{
    public string Nome { get; set; }

    public string Origem { get; set; } = "Desconhecida";

    public EntidadeCosmica(string nome)
    {
        this.Nome = nome;
    }

    public virtual void Manifestar()
    {
        Console.WriteLine($"\nEntidade: {Nome}");

        if (Origem != "Desconhecida")
        {
            Console.WriteLine($"Origem: {Origem}");
        }
    }
}

public class Profundo : EntidadeCosmica
{
    public Profundo(string nome)
        : base(nome)
    {
    }

    public override void Manifestar()
    {
        Console.WriteLine($"\nProfundo {Nome}.");
    }
}

public class MiGo : EntidadeCosmica
{
    public MiGo(string nome)
        : base(nome)
    {
    }

    public override void Manifestar()
    {
        base.Manifestar();

        Console.WriteLine($"{Nome} é meio polvo");
    }
}

public class Pesquisador
{
    public string Nome { get; set; }

    private List<EntidadeCosmica> _catalogo;

    public Pesquisador(string nome)
    {
        this.Nome = nome;
        this._catalogo = new List<EntidadeCosmica>();
    }

    public void Catalogar(EntidadeCosmica e)
    {
        this._catalogo.Add(e);
    }

    public void LerCatalogo()
    {

        foreach (var entidade in _catalogo)
        {
            entidade.Manifestar();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
{
    EntidadeCosmica entidade = 
        new EntidadeCosmica("entidade desconhecida");

    Profundo profundo = 
        new Profundo("polvo");

    MiGo migo = 
        new MiGo("amigo");

    migo.Origem = "amizade";

    Pesquisador pesquisador = 
        new Pesquisador("Professor fulano");

    pesquisador.Catalogar(entidade);
    pesquisador.Catalogar(profundo);
    pesquisador.Catalogar(migo);

    pesquisador.LerCatalogo();

}
}
