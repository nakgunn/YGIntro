using System;

namespace OOP3
{
    class FileLogService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}
