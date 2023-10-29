using System;

namespace ScreamSound {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual seu nome? ");
            string name = Console.ReadLine();
            Console.Write("Qual sua idade? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Qual seu curso na faculdade? ");
            string course = Console.ReadLine();

            Console.WriteLine($"Olá {name}! Vi que você tem {age} anos e atualmente é estudante de {course}");

            void Welcome() {
                Console.WriteLine("Olá mundo!");
            }

            Welcome();

        }
    }
}