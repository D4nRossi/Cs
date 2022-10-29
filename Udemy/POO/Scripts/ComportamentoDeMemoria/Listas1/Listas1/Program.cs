using System;
using System.Collections.Concurrent;
namespace Lista1 {
    class Program {
        static void Main(string[] args) {

            //Lista instanciada
            List<string> list = new List<string>();
            
            //O add adiciona porpadrão no final da lista
            list.Add("Maria");
            list.Add("Bob");
            list.Add("Alex");
            list.Add("Ana");

            //O insert vc tem que colocar o indice de onde quer inserir
            list.Insert(2, "Marco");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------");

            //Ver o tamanho da lista
            Console.WriteLine(list.Count());
            Console.WriteLine("----------------------------");

            //Pegar um primeiro ou ultimo objeto especifico (com uso de funcao lambda) (base em predicado) 
            //Primeiro
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeira pessoa com comeca com 'A' " + s1);
            //Ultimo
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeira pessoa com comeca com 'A' " + s2);

            //Pegar um index especifico (base em predicado)
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeiro com 'A' " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultimo com 'A' " + pos2);
            Console.WriteLine("----------------------------");
            //Filtrar  (base em predicado)
            //Primeiro - criar uma lista que retorne o resultado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            //retorno da lista ja filtrada
            foreach(string x in list2) {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------");

            //Remover

            //O remove espera uma string como parametro
            list.Remove("Alex");
            foreach(string x in list) {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------");

            //O remove all espera como parametro um predicado
            list.RemoveAll(x => x[0] == 'M');
            foreach(string x in list) {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------");

            //O remove at (sem comentarios)
            list.RemoveAt(0);
            foreach(string x in list) {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------");

            //O remove range espera como parametro, onde ele comeca a exclusao, e quantas casas ele vai excluir
            list.RemoveRange(0, 1);
            foreach(string x in list) {
                Console.WriteLine(x);
            }

        }
    }
}