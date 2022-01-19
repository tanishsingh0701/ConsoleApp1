﻿using System.IO;

namespace InterfaceExample
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path; 
        }
        public void LogError(string error)  
        {
            Log(error,"Error");
        }

        public void LogInfo(string message)
        {
            Log(message,"Info");
            
        }

        private void Log(string message, string messageType) 
        {
            using (var streamWritter = new StreamWriter(_path, true))
            {
                streamWritter.WriteLine(messageType+": "+message);
            }

        }
    }
}
