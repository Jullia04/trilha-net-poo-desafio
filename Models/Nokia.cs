using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica do Nokia pode ser feita aqui, se necessário
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalar aplicativos em Nokias
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia.");
        }
    }
}
