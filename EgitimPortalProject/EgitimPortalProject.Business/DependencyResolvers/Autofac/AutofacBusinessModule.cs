using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
 

namespace EgitimPortalProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // örnek yazım kuralı ve sırası
            //builder.RegisterType<UserManager>().As<IUserService>();
            //builder.RegisterType<EfUserDal>().As<IUserDal>();


            // AOP yapıldıgı zaman incelenecek
            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            //    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //    {
            //        Selector = new AspectInterceptorSelector()
            //    }).SingleInstance();
        }
    }
}