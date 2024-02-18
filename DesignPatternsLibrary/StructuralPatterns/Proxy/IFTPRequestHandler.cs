using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StructuralPatterns.Proxy
{
    public interface IFTPRequestHandler
    {
        string HandleFTPRequest();
    }
}
