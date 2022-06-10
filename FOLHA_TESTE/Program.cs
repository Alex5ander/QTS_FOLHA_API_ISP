using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOLHA_API_ISP;

namespace FOLHA_TESTE
{
    class Program
    {
        static List<Funcionario> Empregados;
        static List<Estagiario> Estagiarios;

        static void Main(string[] args)
        {
            
            Empregados = new List<Funcionario>();
            Empregados.Add(new Funcionario(1, "JOAO", 2300));
            Empregados.Add(new Funcionario(2, "MARIA", 2700));
            foreach (Funcionario f in Empregados)
            {
                Console.WriteLine(f.GetType().ToString().Split('.')[1]);
                f.Folha();
                Console.WriteLine("\n");
            }

            Estagiarios = new List<Estagiario>();
            Estagiarios.Add(new Estagiario(1, "JOAO", 2300));
            Estagiarios.Add(new Estagiario(2, "MARIA", 2700));
            foreach (Estagiario f in Estagiarios)
            {
                Console.WriteLine(f.GetType().ToString().Split('.')[1]);
                f.Folha();
                Console.WriteLine("\n");
            }

            Console.ReadKey(); 
        }
    }
}
