using System;
using System.Text;

class Frase
{
        public static void TratandoString()
        {
            //Pangrama co
            string frase = "Hoje à noite, sem luz, dcidi xeretar a quinta gaveta de vovô: achei lingüiça, pão e fubá.";

            //Quantidade de caracteres que existe na frase
            Console.WriteLine(frase.Length);

            //Separando a array por vírgula
            string[] partes = frase.Split(',');

            for(int i = 0; i < partes.Length; i++) 
            {
                //Com trim posso tirar os espaços
                Console.WriteLine(partes[i].Trim());
            }
            //Encontrar uma palavra dentro da frase, retorna booleano
            string subFrase = "quinta";
            var achou = frase.Contains(subFrase);
            Console.WriteLine(achou);

            //IndexOff - Retorna a posição que é encontrada a palavra
            string subPosicao = "quinta";
            int pos = frase.IndexOf(subPosicao);
            Console.WriteLine(pos);

        //SubString
        int posInicial = frase.IndexOf(subPosicao);
        int posFinal = 10;

        string sub = frase.Substring(posInicial, posFinal);
        Console.WriteLine(sub);

        //Deixando o texto maíusculo
        Console.WriteLine(frase.ToUpper());
        //ou minusculo
        Console.WriteLine(frase.ToLower());

        //Trocando informações - a palavra precisa está igual da frase
        string fraseTrocada = frase.Replace("vovô", "mamãe");
        Console.WriteLine(fraseTrocada);

        //Trocando informações - se a palavra não estiver igual da frase
        //NÃO DEU CERTO O REPLACE COM 4 PARAMETROS
        //string fraseTrocada2 = frase.Replace("VOVô", "mamãe", true, CultureInfo.CurrentCulture);
        //Console.WriteLine(fraseTrocada2);

        ////////////////////////////////////////////////////////////////////////
        //Formatando frase
        string nome = "João Victor";
        int idade = 18;
        double rendimento = 800000.00;
        DateTime dataCadastro = new DateTime(2015, 05, 20);
        string texto = "O cliente {0} tem {1} anos de idade e tem rendimento de {2:c}";
        texto += " e é cliente desde {3:dd/MM/yyyy}";

        string frase2 = String.Format(texto, nome, idade, rendimento, dataCadastro);
        Console.WriteLine(frase2);

        ////////////////////////////////////////////////////////////////////////
        ///StringBuilder - concaternar o texto, muito usado com SQL
        StringBuilder builder = new StringBuilder();
        //Posso usar o Append ou AppendLine que quebra o final da frase.
        //builder.Append("");
        builder.AppendLine("A amizade consegue ser tão complexa.");
        builder.AppendLine("Deixa uns desanimados, outros bem felizes.");
        builder.AppendLine("É a alimentação dos fracos.");
        builder.AppendLine("É o reino dos fortes.");

        builder.AppendFormat(texto, nome, idade, rendimento, dataCadastro);

        Console.WriteLine(builder);
    }
    
}
