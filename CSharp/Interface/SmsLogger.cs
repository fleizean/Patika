using System;

namespace Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("SMS Logged.");
        }
    }
}
