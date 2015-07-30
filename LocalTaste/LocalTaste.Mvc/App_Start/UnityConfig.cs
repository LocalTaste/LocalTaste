using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using LocalTaste.Data;
using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Data.Repositories;
using LocalTaste.Business.Managers.Interfaces;
using LocalTaste.Business.Managers;
using LocalTaste.Mvc.Services;

namespace LocalTaste.Mvc.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<LocalTasteDataContext, LocalTasteDataContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserManager, UserManager>();

            container.RegisterType<IRestaurantRepository, RestaurantRepository>();
            container.RegisterType<IRestaurantManager, RestaurantManager>();

            container.RegisterType<IReviewRepository, ReviewRepository>();
            container.RegisterType<IReviewManager, ReviewManager>();

            container.RegisterType<IAuthenticationService, AuthenticationService>();
        }
    }
}
