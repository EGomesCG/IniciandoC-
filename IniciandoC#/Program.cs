using System;

namespace AvancadoCSharp_
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista.TratandoLista();
            ////Tratamento de erro
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = "Tio Patinhas";
                pessoa.Idade = 125;
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Cliente cliente = new Cliente();
            cliente.matricula = 123;
            cliente.nome = "Gilson Reis";
            cliente.email = "gil@gil.com.br";
            cliente.digaOi();

            Console.WriteLine(StatusPedido.Recebido);
            Console.WriteLine(TipoCliente.PessoaFisica);

            Carro carro = new Carro();
            carro.Marca = "Uno";
            carro.AnoFabricacao = 1948;
            Console.WriteLine($"Eu tenho um {carro.Marca} fabricado em {carro.AnoFabricacao}");
            carro.buzinar();
            carro.virar("D");

            Frase.TratandoString();
            Data.TratandoData();
            Console.ReadLine();
        }
    }
}
