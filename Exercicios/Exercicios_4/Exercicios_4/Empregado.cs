using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_4{
    internal class Empregado{

        public string Nome { get; set; }
        public double Sal { get; set; }
        public int Hed { get; set; }
        public int Hen { get; set; }
        public int Nd { get; set; }
        public int Fal { get; set; }
        public double De {  get; set; }
        public double Ref { get; set; }
        public double Val {  get; set; }

        public string Infos(){
            float Smv = 1412;
            double extraTotal = Hed * Sal / 160 + Hen * 1.2 * Sal / 160;
            double salFamilia = Nd* 0.05*Smv;
            double salBruto = Sal + extraTotal + salFamilia;

            return $"Nome do funcionario: {Nome}\nSalario inicial:{Sal}\nHoras extras: {extraTotal}\nSalario familia: {salFamilia}\nSalario bruto: {salBruto}";
        }
        public string Descontos(){
            float Smv = 1412;
            double extraTotal = Hed * Sal / 160 + Hen * 1.2 * Sal / 160;
            double salFamilia = Nd * 0.05 * Smv;
            double salBruto = Sal + extraTotal + salFamilia;

            double INAMPS = 0.08 * Sal;
            double faltas = (Fal * Sal) / 160;
            double impostos = 0.08 * salBruto;
            double desconto = INAMPS + faltas + impostos + Ref + Val + De;
            double salLiquido = salBruto - desconto;

            return $"----------------------\nINAMPS: {INAMPS}\nDesconto das faltas: {faltas}\nGasto com refeiçoes: {Ref}\nGasto com vales: {Val}\nDescontos eventuais: {De}\nImpostos de renda: {impostos}\nSlario liquido: {salLiquido}";
        }
    }
}
