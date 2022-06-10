using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    class Estagiario:IEstagiario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double SB { get; set; }
        public double SL { get; set; }
        public double Bonus { get; set; }
        public Estagiario(int Cod, string Nome, double SB)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.SB = SB;
        }
        public void Ponto(double horas, double SalHora)
        {
            
        }

        public void Imprimir()
        {
           
        }

        public void Calcular()
        {
            
        }

        public void Folha()
        {
            
        }
    }
}
