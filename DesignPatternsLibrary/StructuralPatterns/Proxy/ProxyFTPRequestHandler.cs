using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Proxy
{
    //proxy also implements the interface of the origianl handler
    //it has also reference to the original handler so that it can use it.
    public class ProxyFTPRequestHandler : IFTPRequestHandler
    {
        private readonly FTPRequestHandler _ftpRequestHandler;
        private readonly string _username;

        public ProxyFTPRequestHandler(FTPRequestHandler ftpRequestHandler, string username)
        {
            _ftpRequestHandler = ftpRequestHandler;
            _username = username;
        }
        
        private bool CheckAccess()
        {
            //do some authantication/authorization
            return _username == "eyuphan";
        }

        private bool UseCache()
        {
            //caching
            return true;
        }

        //etc.

        public string HandleFTPRequest()
        {
            if (CheckAccess())
            {
                UseCache();
                return $"Proxy--> {_ftpRequestHandler.HandleFTPRequest()}";
            }
            return "Proxy refused";
        }
    }
}
