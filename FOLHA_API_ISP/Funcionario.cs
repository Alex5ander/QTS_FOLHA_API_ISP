using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    public class Funcionario: IImposto, ISalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double SB { get; set; }
        public double SL { get; set; }
        public Funcionario(int Cod, string Nome, double SB)
        {  
            this.Cod = Cod;
            this.Nome = Nome;
            this.SB = SB;
        }

        public void Calcular()
        {
            double Previdencia = INSS();
            Console.WriteLine("DESCONTO PREV:{0:C2}", Previdencia);
            double IR = IRRF();
            Console.WriteLine("IMP.RENDA: {0:C2}", IR);
            SL = SB - Previdencia - IR;
            Console.WriteLine("DESCONTOS: {0:C2}",(Previdencia + IR));
            Console.WriteLine("SAL. LIQUIDO: {0:C2}",SL);
        }

        public void Folha()
        {
            Console.WriteLine("COD: {0}\tNOME:{1}", Cod, Nome);
            Console.WriteLine("SAL. BRUTO: {0:C2}", SB);
            Console.WriteLine("{0}", "-".PadLeft(30));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Calcular();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public double INSS()
        {
            if (SB < 1830.29) return SB * 0.08;
            else if (SB >= 1830.29 && SB < 3050.52)
                return SB * 0.09;
            else return SB * 0.11;
        }

        public double IRRF()
        {
            // TABELA 2022
            if (SB < 1930.98) return 0;
            else if (SB >= 1930.98 && SB < 2826.65)
                return SB * 0.075;
            else if (SB >= 2826.65 && SB < 3751.05)
                return SB * 0.15;
            else if (SB >= 3751.05 && SB < 4664.68)
                return SB * 0.225;
            else return SB * 0.27;
        }
    }
}
