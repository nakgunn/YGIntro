using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Soyutlama
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // Başvuruyu kredi bağımsız hale getirdik.
        {
            // Başvuran bilgilerini değerlendirme yaparız.
            // 
            krediManager.Hesapla(); // Hangi kredimanager'ı gönderirsek onun hesapla() sı çalışacak.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }        

        }
        
        // Bankacı bir veya birden fazla kredi seçecek ve bu kredileri hesaplayacak.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
