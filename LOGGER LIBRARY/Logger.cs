namespace LOGGER_LIBRARY
{
    public class Logger(Dictionary<LogLevel, List<ILogSink>> sinksByLevel)
    {
        private readonly Dictionary<LogLevel, List<ILogSink>> sinksByLevel = sinksByLevel;

        public void Log(string content, LogLevel level, string ns)
        {
            LogMessage message = new(content, level, ns);
            RouteMessage(message);
        }

        private void RouteMessage(LogMessage message)
        {
            foreach (KeyValuePair<LogLevel, List<ILogSink>> kvp in sinksByLevel)
            {
                if (message.Level >= kvp.Key)
                {
                    foreach (ILogSink sink in kvp.Value)
                    {
                        sink.LogMessage(message);
                    }
                }
            }
        }
    }
}
