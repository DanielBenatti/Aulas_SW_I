namespace Exercicios_4
{
    internal class Program
    {
        static void Main(string[] args){
            Empregado e = new Empregado();
            e.Nome = "Bryan";
            e.Sal = 2000;
            e.Hed = 30;
            e.Hen = 2;
            e.Nd = 6;
            e.Fal = 3;
            e.De = 100;
            e.Ref = 300;
            e.Val = 100;

            Console.WriteLine(e.Infos());
            Console.WriteLine(e.Descontos());
        }
    }
}