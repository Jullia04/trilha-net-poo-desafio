using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização específica do iPhone pode ser feita aqui, se necessário
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalar aplicativos em iPhones
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone.");
        }
    }
}
