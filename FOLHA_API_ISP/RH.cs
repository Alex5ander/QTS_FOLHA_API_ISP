using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    public class RH:IRH
    {
        public ArrayList Empregados;
        
        public RH()
        {
            this.Empregados = new ArrayList();
        }

        public void AddFuncionario(IFuncionario Empregado)
        {
            Empregados.Add(Empregado);
        }

        public void AddEstagiario(IEstagiario Estagiario)
        {
            Empregados.Add(Estagiario);
        }

        public void Imprimir()
        {
            foreach (dynamic e in Empregados)
            {
                Console.WriteLine(e.GetType().ToString().Split('.')[1]);
                e.Imprimir();
                Console.WriteLine("\n");
            }
        }
    }
}
