using System;
using System.Text;

namespace Principios
{
    public class SendNotificationService
    {
        public void send(string medioDeContacto, string mensaje)
        {
            Console.WriteLine($"enviando mensage a {medioDeContacto}: {mensaje}");
        }
    }
}