#region Using Statements
    using System;

    using LightInject;
#endregion



namespace Glimpse.LightInject
{
    public static class LightInjectExtensions
    {
        /// <summary>
        /// Enables the glimpse plugin for LightInject.
        /// </summary>
        /// <param name="container">The container to use.</param>
        /// <exception cref="System.ArgumentNullException">If container is <c>null</c>.</exception>
        public static void EnableGlimpse(this IServiceContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            LightInjectGlimpsePlugin.Container = container;
        }
    }
}
