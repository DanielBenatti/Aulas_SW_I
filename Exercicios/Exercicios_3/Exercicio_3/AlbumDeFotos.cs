using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class AlbumDeFotos{
        private int numDePag;
        private int fotos;

        public int NumDePag{
            get{
                return numDePag;
            }
            set{
                numDePag = value;
            }
        }

        public int Fotos{
            get{
                return fotos;
            }
            set{
                fotos = value;
            }
        }

        public string Resposta(){
            int numTotal = numDePag * 2;
            string resultado = "";
            int resto = 0;

            if(numTotal < Fotos){
                resto = (numTotal - fotos) * (-1);
                resultado = "Você possui mais fotos do que o album pode comportar";
                resultado += "\nHá " + resto + " fotos a mais";
            }else{
                resto = numTotal - fotos;
                resultado = "O seu album pode comportar todas as fotos";
                resultado += "\nHá " + resto + " espaços sobrando";
            }

            return resultado;
    }
    }
}
