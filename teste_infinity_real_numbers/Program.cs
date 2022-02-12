using System;
using System.Collections.Generic;
using System.Linq;

namespace teste_infinity_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int tamanho = 10;
            for (int x = 0; x < 999999; x++)
            {
                var listaReal = new List<string>();
                for (int i = 0; i < tamanho; i++)
                {
                    string numeroRealInteiro = "0.";
                    for (int j = 0; j < tamanho; j++)
                    {
                        numeroRealInteiro += rdn.Next(0, 10);
                        //Console.WriteLine("* " + j);
                    }
                    //Console.WriteLine(numeroRealInteiro);
                    listaReal.Add(numeroRealInteiro);
                }

                int index = 0;
                string numeroCriado = "0.";
                foreach (var numero in listaReal)
                {
                    int tempNum;
                    var arrayNumero = numero.ToString().Replace("0.", "").ToArray();
                    tempNum = int.Parse(arrayNumero[index].ToString().Split(" '")[0]);
                    if(tempNum == 9)
                        tempNum--;
                    else
                        tempNum++;

                    //Console.WriteLine(tempNum);
                    numeroCriado += tempNum.ToString();
                    index++;
                }

                var result = listaReal.Contains(numeroCriado);

                Console.WriteLine(result == true ? "Encontrado " + x : "not match " + x);

                if (result)
                {
                    break;
                }
                //Console.WriteLine(numeroCriado);
            }
            Console.ReadKey();
        }
    }
}
