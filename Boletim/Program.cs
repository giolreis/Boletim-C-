using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Digite seu nome: ");
            x.nome= Console.ReadLine();
            Console.Write("Digite seu curso: ");
            x.curso = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            x.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            x.nota2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\n\nBoletim do aluno !!! \n");
            Console.WriteLine("" + x.nome);
            Console.WriteLine("" + x.curso);
            Console.WriteLine("Nota Final:{0} ",x.Media() );
            Console.WriteLine("Situação Final: {0} \n", x.situacao());      
         



        }
    }
}
