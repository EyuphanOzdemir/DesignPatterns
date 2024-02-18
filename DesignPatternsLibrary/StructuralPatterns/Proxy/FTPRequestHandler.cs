using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Proxy
{
    public class FTPRequestHandler : IFTPRequestHandler
    {
        public string HandleFTPRequest()
        {
            return "Original FTP Handler took care of the request";
        }
    }
}
