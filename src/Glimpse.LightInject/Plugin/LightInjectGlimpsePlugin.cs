#region Using Statements
    using System.Linq;
    using System.Collections.Generic;

    using LightInject;
    using Glimpse.Core.Extensibility;
#endregion



namespace Glimpse.LightInject
{
    public class LightInjectGlimpsePlugin : TabBase
    {
        #region Properties (2)
            internal static IServiceContainer Container { get; set; }

            public override string Name
            {
                get
                {
                    return "LightInject";
                }
            }
        #endregion





        #region Functions (1)
            public override object GetData(ITabContext context)
            {
                if (Container == null)
                {
                    return null;
                }

                IEnumerable<ServiceRegistration> registrations = Container.AvailableServices;
                var data = new List<object[]> { new object[] { "ServiceType", "ServiceName", "Implementation", "Lifetime" } };

                data.AddRange(registrations.Select(registration => new object[]
                {
                    registration.ServiceType.FullName,
                    registration.ServiceName,

                    registration.ImplementingType.FullName,
                    registration.Lifetime.GetType().FullName
                }));

                return data;
            }
        #endregion
    }
}
