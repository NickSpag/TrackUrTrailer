using System;
using SimpleInjector;
using System.Runtime.CompilerServices;
namespace TrackUrTrailer.Standard
{
    public static partial class Help
    {
        public static class Dependencies
        {
            private static Container container;

            private static void EnsureConfigured()
            {
                if (container == null)
                    throw new Exception("Dependency container is not configured yet");
            }

            public static void SetContainer(Container container)
            {
                Dependencies.container = container;
            }

            public static T GetInstance<T>() where T : class
            {
                EnsureConfigured();

                try
                {
                    var instance = container.GetInstance<T>();
                    return container.GetInstance<T>();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

                return null;
            }
        }
    }
}
