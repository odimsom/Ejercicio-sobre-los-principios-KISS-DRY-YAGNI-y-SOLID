using System;

namespace NotificationSystem
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
    
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando Email: {message}");
        }
    }
    
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando SMS: {message}");
        }
    }
    
    public class LogService
    {
        public void LogNotification(string notificationType, string message)
        {
            Console.WriteLine($"Notificación {notificationType} registrada en logs.");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            
            string option = Console.ReadLine();
            
            INotificationService notificationService;
            string notificationType;
            
            if (option == "1")
            {
                notificationService = new EmailNotificationService();
                notificationType = "Email";
            }
            else
            {
                notificationService = new SmsNotificationService();
                notificationType = "SMS";
            }
            
            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();
            
            notificationService.SendNotification(message);
            
            LogService logService = new LogService();
            logService.LogNotification(notificationType, message);
        }
    }
}
