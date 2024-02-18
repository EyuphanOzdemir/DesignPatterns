using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Proxy
{
    public class ProxyDemonstrator : IPatternDemonstrator
    {
        public string Demonstrate(params string[] parameters)
        {
            return new ProxyFTPRequestHandler(new FTPRequestHandler(), parameters[0]).HandleFTPRequest();
        }
    }
}
