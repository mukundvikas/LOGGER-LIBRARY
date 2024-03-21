namespace LOGGER_LIBRARY
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileSink = new FileSink("log.txt");

            var sinksConfig = new Dictionary<LogLevel, List<ILogSink>>
            {
                { LogLevel.DEBUG, new List<ILogSink> { fileSink } },
                { LogLevel.INFO, new List<ILogSink> { fileSink } },
                { LogLevel.WARN, new List<ILogSink> { fileSink } },
                { LogLevel.ERROR, new List<ILogSink> { fileSink } },
                { LogLevel.FATAL, new List<ILogSink> { fileSink } }
            };

            var logger = new Logger(sinksConfig);

            // Creating log.txt logger file inside the loder ocation LOGGER LIBRARY\LOGGER LIBRARY\bin\Debug\net8.0\log.txt  

            logger.Log("This is an info message", LogLevel.INFO, "DevOnAssigment");
            logger.Log("This is a warning message", LogLevel.WARN, "DevOnAssigment");
        }
    }
}
