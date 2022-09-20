using System; //refererencia ao name space padrão do .NET
using System.Globalization; //definições de formatação


namespace Saida {
    class Program {
        static void Main(string[] args) {
            //limitar casa decimais de um float/double
            double limite = 10.6486468426;
            //mostrar somente 2 decimais
            Console.WriteLine(limite.ToString("F2"));

            //formatando o float/double
            Console.WriteLine(limite.ToString("F4", CultureInfo.InvariantCulture)); // imprimi com o '.' e não a ','


            //esquema de placeholder
            double saldo = 10.5;
            string nome = "Daniel";
            int idade = 20;

            //é tipo uma concatenação, mas com design diferente
            Console.WriteLine("{0} tem {1} anos e possui {2} reais", nome, idade, saldo);

            //interpolação parece o template string do Js
            Console.WriteLine($"{nome} tem {idade} e tem {saldo} reais");

            //não vou fazer a da concatenação kkkkkkkk



            //EXERCICIO DE FIXAÇÂO (tosco, mas vou fazer)


            //declaação de variaveis
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";
            char genero = 'M';

            byte age = 20;
            int codigo = 5290;
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            //prints

            Console.WriteLine($"Produto: \r\n{produto1}, cujo preço é R${preco1} \r\n {produto2}, cujo preço é {preco2}" +
                             $"\r\n \r\n Registro: {age} de idade, código {codigo} e gênero: {genero} \r\n \r\n"+
                             $"Medida com oito casa decimais: {medida.ToString("F8")} \r\n"+
                             $"Arredondano 3 casa decimais: {medida.ToString("F3")} \r\n"+
                             $"Separar decimal com ',': {medida.ToString("F3", CultureInfo.InvariantCulture)}");





        }
    }
}