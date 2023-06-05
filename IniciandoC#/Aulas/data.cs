using System;
using System.Text;

class Data
{
    public static void TratandoData()
    {
        //Data de hoje
        Console.WriteLine("{0}", DateTime.Now);
        //Data daqui 2 dias
        Console.WriteLine("{0}", DateTime.Now.AddDays(2));
        //Data dois dias atrás
        Console.WriteLine("{0}", DateTime.Now.AddDays(-2));

        //Formatando data
        //Instânciando data - Ano, mês, dia, hora, minuto e segundo
        DateTime data = new DateTime(2018, 04, 02, 08, 30, 00);
        Console.WriteLine(data);

        //Data que vem do banco ou formulário, usamos o Parse para formatar string
        string dataBD = "2021-05-15 08:33:05";
        DateTime data1 = DateTime.Parse(dataBD);
        Console.WriteLine(data1);

        //Formatando hora 08h30
        string dataBD1 = "2023-05-15 23:15:22";
        DateTime data2 = DateTime.Parse(dataBD1);
        string dataHoraMinuto = String.Format("{0:HH}h{0:MM}", data2);
        Console.WriteLine(dataHoraMinuto);

        //Formatando hora 08h30
        string dataBD2 = "2020-05-15 23:15:22";
        DateTime data3 = DateTime.Parse(dataBD2);
        string dataFormatada = String.Format("{0:dd/MM/yyyy}", data3);
        Console.WriteLine(dataFormatada);
    }   
}
