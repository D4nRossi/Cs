/*
    Encapsulamento
    - É um principio que consiste em esconder detalhes de implementacoes de um componente, expondo apenas operacoes seguras e que o mantenha em um estado consistente
    - Regra de Ouro: o objeto deve sempre estar em um estado consistente, e a propria classe deve garantir isso


    Opcao 1:
    - Todo atributo é definido como private
    - Implementa-se metodos Get e Set para cada atributo, conforme regras de negocio
    - Nota: não é usual em C#
 */

using System;
using This;

namespace Sobrecarga
{
    class Program
    {
        static void Main(String[] args)
        {
            

            Produto p = new Produto("TV", 500, 10);
            Console.Write("Novo nome: ");
            p.SetNome(Console.ReadLine());
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}