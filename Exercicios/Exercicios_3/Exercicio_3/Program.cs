namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args){
            AlbumDeFotos a = new AlbumDeFotos();
            Console.WriteLine("Quantas paginas possui o seu album?");
            a.NumDePag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantas fotos deseja colocar?");
            a.Fotos = Convert.ToInt32(Console.ReadLine());

            a.Resposta();
            Console.WriteLine(a.Resposta());
        }
    }
}