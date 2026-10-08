using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Grimorio
{
    public string FeiticoFavorito { get; set; } = "Nenhum";

    public void Abrir()
    {
        Console.WriteLine($"Feitiço favorito: {FeiticoFavorito}");
    }
}

public class Companheiro
{
    public string Nome { get; set; }
    public string Funcao { get; set; }

    public Companheiro(string nome, string funcao)
    {
        this.Nome = nome;
        this.Funcao = funcao;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome} Função: {Funcao}");
    }
}

public class Maga
{
    public string Nome { get; set; }

    // COMPOSIÇÃO: grimorio criado dentro da Maga
    //nasce junto e pertence a ela
    public Grimorio Grimorio { get; set; }

    // AGREGação: companheiros foram criados fora da Maga
    // podem existir sem ela
    private List<Companheiro> _companheiros;

    public Maga(string nome)
    {
        this.Nome = nome;

        // Composição: grimorio é criado dentro do construtor da Maga
        this.Grimorio = new Grimorio();

        this._companheiros = new List<Companheiro>();
    }

    // Agregação: recebe um companheiro que já existe
    public void Recrutar(Companheiro c)
    {
        this._companheiros.Add(c);
    }

    public void MostrarGrupo()
    {
        Console.WriteLine($"\nGrupo de {Nome}:");

        foreach (var companheiro in _companheiros)
        {
            companheiro.Apresentar();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
		Companheiro stark = new Companheiro("Stark", "Guerreiro");
        Companheiro fern = new Companheiro("Fern", "Maga");

        Maga frieren = new Maga("Frieren");

        frieren.Recrutar(stark);
        frieren.Recrutar(fern);

        frieren.Grimorio.FeiticoFavorito = "Magia para copiar feitiços";

        frieren.MostrarGrupo();

        Console.WriteLine("\nGrimório");
        frieren.Grimorio.Abrir();
    }
}
