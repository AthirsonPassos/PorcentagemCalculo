using System;

namespace PorcentagemCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53, total = 0,
                  psp, prj, pmg, pes, poutros;

            Console.WriteLine("Faturamento Mensal da Distribuidora em cada Estado!");
            Console.WriteLine("São Paulo: R${0}", sp);
            Console.WriteLine("Rio de Janeiro : R${0}", rj);
            Console.WriteLine("Minas Gerais: R${0}", mg);
            Console.WriteLine("Espírito Santo: R${0}", es);
            Console.WriteLine("Outros: R${0}", outros);
            total = sp + rj + mg + es + outros;
            Console.WriteLine("Total: R${0}", total);
            Console.ReadKey();
            //Calculo das Porcentagens
            psp = (sp*100)/total;
            prj = (rj * 100) / total;
            pmg = (mg * 100) / total;
            pes = (es * 100) / total;
            poutros = (outros * 100) / total;

            Console.WriteLine("Percentual Mensal da Distribuidora em cada Estado!");
            Console.WriteLine("São Paulo: {0}%", psp);
            Console.WriteLine("Rio de Janeiro: {0}%", prj);
            Console.WriteLine("Minas Gerais: {0}%", pmg);
            Console.WriteLine("Espírito Santo: {0}%", pes);
            Console.WriteLine("Outros: {0}%", poutros);
            Console.ReadKey();

            //By Athirson Passos
        }
    }
}
