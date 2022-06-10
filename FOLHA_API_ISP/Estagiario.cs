using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_API_ISP
{
    public class Estagiario:IEstagiario
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
            this.SB = horas * SalHora;
        }

        public void Imprimir()
        {
            Folha();
        }

        public void Calcular()
        {
            Bonus = SB * 0.02;
            SL = SB + Bonus;
            Console.WriteLine("BONUS SAL: {0:C2}", Bonus);
            Console.WriteLine("SAL. LIQUIDO: {0:C2}", SL);
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
    }
}
