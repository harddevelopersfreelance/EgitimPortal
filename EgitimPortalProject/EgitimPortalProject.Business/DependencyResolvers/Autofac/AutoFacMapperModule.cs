using Autofac;
using AutoMapper;
using EgitimPortalProject.Business.Mappings.AutoMapper;

namespace EgitimPortalProject.Business.DependencyResolvers.Autofac
{
    public class AutoFacMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CustomMappingProfile());
            });

            builder.RegisterInstance(mappingConfig);

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterModule(new AutoFacMapperModule());
        }
    }
}