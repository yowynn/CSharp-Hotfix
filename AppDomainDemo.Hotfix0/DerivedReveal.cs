using AppDomainDemo.Common;
using System;

namespace AppDomainDemo.Hotfix0
{
    internal class DerivedReveal : MarshalByRefObject, IReveal
    {
        public void Reveal()
        {
            Console.WriteLine("current domain: {0}", AppDomain.CurrentDomain.FriendlyName + Environment.NewLine);
        }
    }
}
