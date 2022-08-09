using System;

static class LogLine
{
    public static string Message(string logLine)
    {   
        int iMsg1 = logLine.IndexOf(':') + 1;

        string msg1 = (logLine.Substring(iMsg1)).Trim();
        
        return msg1; 
    }

    public static string LogLevel(string logLine)
    {
        int iLog = logLine.IndexOf(':') - 1;
        string log = (logLine.Substring(0,iLog)).Trim();
        string msg;
        char[] toRemove = {'[',']'};
        
        msg = (log.Trim(toRemove)).ToLower();

        return msg;
    }

    public static string Reformat(string logLine)
    {
        string res1 = Message(logLine);
        string res2 = LogLevel(logLine);
        
        string resTotal = $"{res1} ({res2})";

        return resTotal;
    }
}
