using System;
using System.Reflection;

namespace Annotation
{

    [AttributeUsage(AttributeTargets.Method)]
    public class StatusAttribute : Attribute
    {
        public string Stage { get; }

        public StatusAttribute(string stage)
        {
            Stage = stage;
        }
    }


    public class FeatureManager
    {
        [Status("Stable")]
        public void LegacyBillingSystem()
        {
            Console.WriteLine("Running old reliable billing...");
        }

        [Status("Experimental")]
        public void CryptoPaymentBeta()
        {
            Console.WriteLine("Running risky beta feature...");
        }
    }
}