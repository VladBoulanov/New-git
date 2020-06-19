using System;

public class LogWriterFactory
{
    public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
    {
        T singletone = T.Instance();    
    }
}
