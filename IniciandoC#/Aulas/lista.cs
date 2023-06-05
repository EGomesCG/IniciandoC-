using System;
using System.Collections;
using System.Collections.Generic;

class Lista
{
    public static void TratandoLista()
    {
        //Este tipo de lista consigo add, remover e manipular os dados dentro da lista
        ArrayList arrayList = new ArrayList();
        //Este tipo de lista também me possibilita utilizar vários metodos
        arrayList.Add("Gilson");
        arrayList.Add(34);
        arrayList.Add(new object());

        List<string> dias = new List<string>();
        dias.Add("Domingo");
        dias.Add("Segunda");
        dias.Add("Terça");
        dias.Add("Quarta");
        dias.Add("Quinta");
        dias.Add("Sexta");
        dias.Add("Sábado");

        foreach (string dia in dias)
        {
            Console.WriteLine(dia);
        }
        //Outra forma de tratar lista
        List<Carro> veiculos = new List<Carro>();
        Carro carro = new Carro();
        carro.Marca = "Civic";
        carro.AnoFabricacao = 1978;
        veiculos.Add(carro);

        Carro carro1 = new Carro();
        carro1.Marca = "Fusca";
        carro1.AnoFabricacao = 1980;
        veiculos.Add(carro1);

        Carro carro2 = new Carro();
        carro2.Marca = "Mustang";
        carro2.AnoFabricacao = 1982;
        veiculos.Add(carro2);

        foreach (Carro veiculo in veiculos)
        {
            Console.WriteLine($"Eu tenho um carro {veiculo.Marca} fabricado em {veiculo.AnoFabricacao}.");
        }
    }
}