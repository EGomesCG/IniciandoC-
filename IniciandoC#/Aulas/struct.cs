using System;
//24 bits uma struct suporta, acima disto é aconcelhavel criar uma classe.
public struct Cliente
{
    public int matricula;
    public string nome;
    public string email;

    public void digaOi()
    {
        Console.WriteLine($"Oi {this.nome}");
    }
}
