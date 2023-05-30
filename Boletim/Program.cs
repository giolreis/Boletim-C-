using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            //ALTERAÇÕES FEITAS POR: Natália Maria Secco Souza
            Console.Write("Digite seu nome completo: ");
            x.nome= Console.ReadLine();
            Console.Write("Digite seu curso: ");
            x.curso = Console.ReadLine();
            x.semestre = Console.ReadLine();        //Alteração feita por <<Alisson Bastos>>
            Console.Write("Digite a primeira nota: ");
            x.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            x.nota2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\n\nBoletim do aluno !!! \n");
            Console.WriteLine("" + x.nome);
            Console.WriteLine("" + x.curso);
            Console.WriteLine("Nota Final:{0} ",x.Media() );
            //ALTERAÇÕES FEITAS POR: Natália Maria Secco Souza
            Console.WriteLine("Situação Final (Aprovado ou Reprovado): {0} \n", x.situacao());
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("Muito Obrigado por consultar !");
         



        }
    }
}
