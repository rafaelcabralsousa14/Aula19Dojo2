namespace Aula19Dojo2
{
    public class IngressoVIP : Ingresso
    {
        public float valorAdicional { get; set; }    

        public void ImprimirValorVIP(){
            float resultadoV = Valor + valorAdicional;
            System.Console.WriteLine("O valor do ingresso VIP é "+resultadoV);
        } 
        public void MostrarDiferença(){
            float resultado = valorAdicional;
            System.Console.WriteLine("A diferença entre o valor comum e o do VIP é "+resultado);
        }
    }
}