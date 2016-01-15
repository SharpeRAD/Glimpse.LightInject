#region Using Statements
    using System.Linq;
    using System.Collections.Generic;

    using LightInject;
    using Glimpse.Core.Extensibility;
#endregion



namespace Glimpse.LightInject
{
    /// <summary>
    /// LightInject plugin for Glimpse
    /// </summary>
    public class LightInjectGlimpsePlugin : TabBase
    {
        #region Properties (2)
            internal static IServiceContainer Container { get; set; }

            /// <summary>
            /// The name of the plugin
            /// </summary>
            public override string Name
            {
                get
                {
                    return "LightInject";
                }
            }
        #endregion





        #region Functions (1)
            /// <summary>
            /// Gets data to fill the glimpse tab with
            /// </summary>
            /// <param name="context">The glimpse context.</param>
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
