using AppDomainDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainDemo.Hotfix1
{
    internal class DerivedReveal : MarshalByRefObject, IReveal
    {
        public void Reveal()
        {
            Console.WriteLine("current domain: {0}", AppDomain.CurrentDomain.FriendlyName + Environment.NewLine);
        }
    }
}
