using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLogggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı..");
        }
    }
}
