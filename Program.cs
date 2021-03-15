using System;
using System.Linq;


namespace CShp_LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Método de extensão Select aplicado a um array de strings que especifica uma expressão lambda que aplica o método ToUpper a cada elemento do array

            string[] frutas = { "banana", "laranja", "manga", "abacate", "goiaba" };

            var resultado = frutas.Select(element => element.ToUpper());

            foreach (string fruta in resultado)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine("\n");

            // Converte array de strings em um array de inteiros, e exibi os valores ordenados.

            string[] valores = { "405", "560", "11", "17", "856" };

            int[] numeros = valores.Select(id => int.Parse(id)).OrderBy(i => i).ToArray();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n");


            //  Método de extensão LINQ com diferentes expressões lambdas para remover as strings vazias e valores null;

            string[] bau = { "mariana", "", "net", null, null, "C#", null, "", "2020" };
                        
            var resultado1 = bau.Where(item => item != null); // remove somente os nulls

            foreach (string item in resultado1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n==========================================\n");
                            
            var resultado2 = bau.Where(item => !string.IsNullOrEmpty(item)); // Usa método Where para remover null e strings vazias

            foreach (string valor in resultado2)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("\n");

            // Conta quantos valores são true e quantos são false

            bool[] respostas = { true, false, true, true, false, true, true, false };

            var verdade = respostas.Count(resp => (resp));
            var mentira = respostas.Count(resp => (!resp));

            Console.WriteLine($"Temos {verdade} respostas true e {mentira} respostas false");

            Console.ReadLine();
        }
    }
}