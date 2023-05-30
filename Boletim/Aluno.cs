using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    internal class Aluno
    {

        public string nome;
        public string curso;
        public double nota1;
        public double nota2;
        public double nota3;        //Alteração feita por <<Alisson Bastos>>
        public double media;
        public string semestre;         //Alteração feita por <<Alisson Bastos>>


        public double Media()
        {
            media = (nota1 + nota2) / 2;
            return media; 

        }

        public string situacao()
        {
            if (media <=6 && media >=3)     //Alteração feita por <<Alisson Bastos>>
            {
                return "IFA";
            }
            else if (media <4) {
                return "Reprovado";
            }
            else
            {
                return "Aprovado";
            }
        }



    } 
}
