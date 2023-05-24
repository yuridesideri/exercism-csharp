using System;

static class LogLine {
    public static string Message( string logLine ) {
        string errorLevel = "[ERROR]", warningLevel = "[WARNING]", infoLevel = "[INFO]";

        if(logLine.StartsWith(errorLevel)) {
            string parsedLogLine = logLine[(errorLevel.Length + 2)..].Trim();
            return parsedLogLine;

        } else if(logLine.StartsWith(warningLevel)) {
            string parsedLogLine = logLine[(warningLevel.Length + 2)..].Trim();
            return parsedLogLine;
        } else if(logLine.StartsWith(infoLevel)) {
            string parsedLogLine = logLine[(infoLevel.Length + 2)..].Trim();
            return parsedLogLine;
        } else {
            return logLine;
        }

        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel( string logLine ) {
        string errorLevel = "[ERROR]", warningLevel = "[WARNING]", infoLevel = "[INFO]";

        if(logLine.StartsWith(errorLevel)) {
            string parsedLogLine = errorLevel.Replace("[", "").Replace("]", "").ToLower();
            return parsedLogLine;

        } else if(logLine.StartsWith(warningLevel)) {
            string parsedLogLine = warningLevel.Replace("[", "").Replace("]", "").ToLower();
            return parsedLogLine;

        } else if(logLine.StartsWith(infoLevel)) {
            string parsedLogLine = infoLevel.Replace("[", "").Replace("]", "").ToLower();
            return parsedLogLine;

        } else {
            return logLine;
        }

        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat( string logLine ) {
        return $"{Message(logLine)} ({LogLevel(logLine)})";

        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
