using System;
using System.Text;

class Carro
{
    //Classe é um objeto da vida real(carro),
    //os metodos são ações dessa classe(andar, corre,..) e
    //as propriedade as caracteristicas/atributos deste objeto(cor, modelo, etc)
    private string marca;//Quando privado não é acessado direto precisa 
    public string Marca 
    {
        get => marca;
        set => marca = value.Equals("Fusca") ? "Outro Carro" : value;

        //get { return _marca; }
        //set { _marca = value; }

        //get; set;
    }

    private int anoFabricacao;
    public int AnoFabricacao 
    { get => anoFabricacao; set => anoFabricacao = value; }

    public void buzinar()
    {
        Console.WriteLine("Biii Biiii");
    }

    public void virar(string direcao)
    {
        if(direcao.Equals("D"))
        {
            Console.WriteLine("Virando a direita...");
        } else
        {
            Console.WriteLine("Virando a esquerda...");
        }
    }
}
