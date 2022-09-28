using System;
namespace Foreach {
    class Program { 
        static void Main(string[] args) {

            //Sintaxe opcional e simplificada para percorrer colecoes

            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            // obj é só um apelido (pode ser qualquer coisa)
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}