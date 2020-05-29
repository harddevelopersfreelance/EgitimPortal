using Autofac;
using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;
using Project.Business.ValidationRules.FluentValidation;

namespace EgitimPortalProject.Business.DependencyResolvers.Autofac
{
    public class AutoFacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IValidator<Users>>().As<UserValidator>().SingleInstance();



            // program.cs de eklendi burada gerek kalmayabilir denenecek
            builder.RegisterModule(new AutoFacValidationModule());
        }
    }
}