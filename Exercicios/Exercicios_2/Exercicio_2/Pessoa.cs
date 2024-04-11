using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2{
    internal class Pessoa{

        private string nome;
        private DateTime nascimento;
        private double altura;

        public string Nome{
            get{
                return nome;
            }
            set{
                nome = value;
            }
        }
        public DateTime Nascimento { 
            get{
                return nascimento;
            }
            set{
                nascimento = value;
            }
        }

        public double Altura{
            get{
                return altura;
            }
            set{
                altura = value;
            }
        }
        public int Idade()
        {
            return DateTime.Today.Year - nascimento.Year;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de Nascimento: " + nascimento);
            Console.WriteLine("Altura: " + altura);
        }

    }
}
