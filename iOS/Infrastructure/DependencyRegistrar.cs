using System;
using SimpleInjector;
using TrackUrTrailer.Standard;

namespace TrackUrTrailer.iOS
{
    public static class DependencyRegistrar
    {
        internal static Container IOSContainer()
        {
            var dependencyContainer = new Container();
            dependencyContainer.Register<IMapAnnotation, TUTMapAnnotation>(Lifestyle.Singleton);

            return dependencyContainer;
        }
    }
}