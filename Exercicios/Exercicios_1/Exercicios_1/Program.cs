namespace Exercicios_1{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("CALCULAR A AREA DE UM QUADRADO/RENTANGULO!!");
            Area area = new Area();

            Console.WriteLine(area.Calculo());
            Console.WriteLine(area.Dados());
        }
    }
}