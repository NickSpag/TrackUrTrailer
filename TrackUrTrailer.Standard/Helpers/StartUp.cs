using System;
using SimpleInjector;
namespace TrackUrTrailer.Standard
{
    public static partial class Help
    {
        public static class StartUp
        {
            public static void InitializeWithDependencies(Container dependencyContainer)
            {
                dependencyContainer.Register<IDataStore<TUTOrder>, CloudDataStore>();
                Help.Dependencies.SetContainer(dependencyContainer);
            }
        }
    }
}
