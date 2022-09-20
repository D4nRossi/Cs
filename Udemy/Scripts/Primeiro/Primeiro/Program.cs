using System; //refererencia ao name space padrão do .NET

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            //declaração de variaveis
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 21474836478L;
            bool enzoBroxa = false;
            char foda = 'Ç'; // da pra usar o unicode (tem o site deles), fica '\u + unicode'
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Daniel Rossi";
            object obj1 = "4lan mãos fofas";
            object obj2 = 4.5f;

            //funções com as variaveis
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            if (enzoBroxa == true) {
                Console.WriteLine("Pal mole kkkkkkk");
            } else {
                Console.WriteLine("Enzo deu o cu" + n4 + " vezes!!!");
            }
            Console.WriteLine(foda);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
/*
 
 Tipos de dados(se nn lembrar pesquisa kkkkkkkk)
 
sbyte
short
int
long
byte
ushort
uint
ulong
float
double
decimal
char
bool
 
 
 */

