using System;

namespace arayuzler
{

    class Program
    {

        static void Main(string[] args)
        {
            FileLogger filelogger=new FileLogger();
            filelogger.writeLog();

            DatabaseLogger databaselogger=new DatabaseLogger(); 
            databaselogger.writeLog();

            SmsLogger smslogger=new SmsLogger();
            smslogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();
        }
    }
}
