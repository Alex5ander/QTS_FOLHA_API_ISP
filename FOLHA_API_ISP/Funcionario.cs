using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    public class Funcionario : IImposto, ISalario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; };
        public double SB { get; set; }
        public double SL { get; set; }
        public Funcionario(int Codigo, string Nome, double SB)
        {  
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.SB = SB;
        }

        public void Calcular()
        {
            throw new NotImplementedException();
        }

        public void Folha()
        {
            throw new NotImplementedException();
        }

        double IImposto.INSS()
        {
            throw new NotImplementedException();
        }

        double IImposto.IRRF()
        {
            throw new NotImplementedException();
        }
    }
}
