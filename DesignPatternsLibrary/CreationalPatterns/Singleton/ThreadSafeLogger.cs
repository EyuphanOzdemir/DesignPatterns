using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.CreationalPatterns.Singleton
{
    public class ThreadSafeLogger

    {
        private static readonly object _lock = new();

        private static ThreadSafeLogger? _instance;

        private ThreadSafeLogger()
        {
        }

        public static ThreadSafeLogger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeLogger();
                    }

                    return _instance;
                }
            }
        }

        public void Log(string message) => Console.WriteLine(message);
    }
}
