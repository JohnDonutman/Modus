using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> vstupy = new List<int>();
            while (true)
            {
                String vstupString = Console.ReadLine();
                if (int.TryParse(vstupString, out int vstup))
                {
                    vstupy.Add(vstup);
                } else
                {
                    break;
                }
            }

            vstupy.Sort();

            int aktualniModus = vstupy[0];
            int posledniCislo = vstupy[0];
            int pocetVyskytu = 1;
            int maximalniPocetVyskytu = 1;

            for (int i = 1; i < vstupy.Count; i++)
            {
                if (vstupy[i] == posledniCislo)
                {
                    pocetVyskytu++;
                }
                else
                {
                    if (pocetVyskytu > maximalniPocetVyskytu)
                    {
                        maximalniPocetVyskytu = pocetVyskytu;
                        aktualniModus = vstupy[i-1];
                    }
                    pocetVyskytu = 1;
                }
                posledniCislo = vstupy[i];
            }
            if (pocetVyskytu > maximalniPocetVyskytu)
            {
                aktualniModus = vstupy[vstupy.Count - 1];
            }
            Console.WriteLine("Modus ve vašich číslech je: {0}", aktualniModus);
        }
    }
}
