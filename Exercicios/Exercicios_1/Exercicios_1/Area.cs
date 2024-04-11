using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_1 {
    public class Area{
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Total { get; set; }

        public string Calculo(){
            Console.WriteLine("digite o valor da base de uma forma em cm");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o valor da altura de uma forma em cm");
            Altura = Convert.ToDouble(Console.ReadLine());
            Total = Base * Altura;

            string tipo = "";
            if(Altura == Base){
                tipo = "Quadrado";
            }else{
                tipo = "Retângulo";
            }

            string resultado = "Você descreveu um "+tipo+ " e a área dele é " + Total;
            
            return resultado;
        }
        public string Dados(){
            string inform = "Tendo Base igual a " + Base ;
            inform += "\nE altura igual a " + Altura;
            return inform;
        }
    }
}
