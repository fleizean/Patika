using System;

namespace Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileLogger flogger = new FileLogger();
            flogger.WriteLog();

            DatabaseLogger dlogger = new DatabaseLogger();
            dlogger.WriteLog();

            SmsLogger slogger = new SmsLogger();
            slogger.WriteLog();

            LogManager lmanager = new LogManager(new FileLogger());
            lmanager.WriteLog();
        }
    }
}