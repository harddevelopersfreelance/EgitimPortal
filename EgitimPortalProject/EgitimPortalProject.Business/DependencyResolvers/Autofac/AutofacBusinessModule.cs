using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using EgitimPortalProject.Business.Abstract;
using EgitimPortalProject.Business.Concrete;
using EgitimPortalProject.Business.Concrete.EntityManagers;
using EgitimPortalProject.Core.Utilities.Security.Jwt;
using EgitimPortalProject.DataAccess.Abstract;
using EgitimPortalProject.DataAccess.Concrete.EntityFramework;

namespace EgitimPortalProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // örnek yazım kuralı ve sırası
            

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<UserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


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