using Autofac;
using ForgetMeNot.DAL;
using ForgetMeNot.Services.Implementations;
using ForgetMeNot.Services.Interfaces;

namespace ForgetMeNot.Services
{
    public static class ServiceResolver
    {
        public static void ResolveServices(this ContainerBuilder builder)
        {
            builder
                .RegisterType<EfCoreContext>()
                .As<EfCoreContext>()
                .InstancePerLifetimeScope();
            builder.RegisterType<AuthService>().As<IAuthService>()
                .SingleInstance();
            builder.RegisterType<ChoreService>().As<IChoreService>()
                .InstancePerDependency();
            builder.RegisterType<PlantService>().As<IPlantService>()
                .InstancePerDependency();
        }
    }
}