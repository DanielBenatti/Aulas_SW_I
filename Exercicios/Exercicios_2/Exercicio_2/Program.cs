namespace Exercicio_2
{
    internal class Program{
        static void Main(string[] args){
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Bryan";
            pessoa1.Nascimento = new DateTime(2008, 4, 6);
            pessoa1.Altura = Convert.ToDouble(1.69);

            pessoa1.Imprimir();

            int idade = pessoa1.Idade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}