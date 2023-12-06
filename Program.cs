using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Aqui você pode criar instâncias de suas classes e realizar operações, se necessário
            Nokia nokia = new Nokia("123", "ModeloNokia", "IMEINokia", 64);
            Iphone iphone = new Iphone("456", "ModeloIphone", "IMEIIphone", 128);

            // Exemplo de chamada ao método InstalarAplicativo
            nokia.InstalarAplicativo("AppNokia");
            iphone.InstalarAplicativo("AppiPhone");

            // Exemplo de chamada a outros métodos, se necessário
            nokia.Ligar();
            iphone.ReceberLigacao();
        }
    }
}
