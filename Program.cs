using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {

            IngressoVIP ingressovip = new IngressoVIP();
            ingressovip.Valor = 50;
            ingressovip.valorAdicional = 100;
            ingressovip.ImprimirValor();
            ingressovip.ImprimirValorVIP();
            ingressovip.MostrarDiferença();

        }
    }
}
