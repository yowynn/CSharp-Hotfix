using AppDomainDemo.Common;
using System;

namespace AppDomainDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("current domain: {0}", AppDomain.CurrentDomain.FriendlyName + Environment.NewLine);

            AppDomain hotfix0 = AppDomain.CreateDomain("hotfix0");
            IReveal reveal0 = (IReveal)hotfix0.CreateInstanceFromAndUnwrap("AppDomainDemo.Hotfix0.dll", "AppDomainDemo.Hotfix0.DerivedReveal");
            reveal0.Reveal();
            AppDomain.Unload(hotfix0);

            AppDomain hotfix1 = AppDomain.CreateDomain("hotfix1");
            IReveal reveal1 = (IReveal)hotfix1.CreateInstanceFromAndUnwrap("AppDomainDemo.Hotfix1.dll", "AppDomainDemo.Hotfix1.DerivedReveal");
            reveal1.Reveal();
            AppDomain.Unload(hotfix1);
            // reveal1.Reveal();   // System.AppDomainUnloadedException
            Console.Read();
        }
    }
}
