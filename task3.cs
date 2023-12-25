using System;

namespace task3
{
    // Базовый класс DocumentWorker
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine($"Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine($"Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine($"Сохранение документа доступно в версии Pro");
        }
    }

    // Производный класс ProDocumentWorker
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine($"Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine($"Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    // Производный класс ExpertDocumentWorker
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine($"Документ сохранен в новом формате");
        }
    }
    internal class Program
    { 
        public static void Main(string[] args) 
        {
            string keyPro = "1234Pro"; 
            string keyExp = "1234Exp";
            
            Console.WriteLine($"Please enter the key"); 
            string userKey = Console.ReadLine();
            if (userKey == keyPro)
            {
                ProDocumentWorker document1 = new ProDocumentWorker();
                document1.OpenDocument(); 
                document1.EditDocument();
                document1.SaveDocument();
            }
            else if (userKey == keyExp)
            {
                    ExpertDocumentWorker document1 = new ExpertDocumentWorker();
                    document1.OpenDocument();
                    document1.EditDocument();
                    document1.SaveDocument();
            }
            else if ((userKey != keyExp) && userKey != keyPro)
            {
                    DocumentWorker document1 = new DocumentWorker();
                    document1.OpenDocument();
                    document1.EditDocument();
                    document1.SaveDocument();
            }
        }
    }
}
