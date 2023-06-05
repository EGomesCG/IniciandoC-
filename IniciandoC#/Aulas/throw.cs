using System;
using static System.Console;

class Pessoa
{
    private string nome;
    private int idade;   

    public string Nome { get => nome; set => nome = value; }
    public int Idade 
    { 
        get => idade; 
        set => idade = value < 0 || value > 120 ? throw new Exception("Idade inválida") : value; 
    }
}