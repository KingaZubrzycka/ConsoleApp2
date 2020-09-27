using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FeatureA
    {
        public int Add()
        {
            int x1 = 1;
            int x2 = 1;
            int sum = x1 + x2;
            return sum;

        }
    }
    
}
