using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOLHA_API_ISP;
using System.Collections;

namespace FOLHA_TESTE
{
    class Program
    {
        static IRH empresa;

        static void Main(string[] args){

            empresa = new RH();
            empresa.AddFuncionario(new Funcionario(1, "JOAO", 2300));
            empresa.AddEstagiario(new Estagiario(2, "MARIA", 2700));

            empresa.Imprimir();

            Console.ReadKey(); 
        }
    }
}
