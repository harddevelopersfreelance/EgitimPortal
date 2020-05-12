using AutoMapper; 

namespace EgitimPortalProject.Business.Mappings.AutoMapper
{
    public class CustomMappingProfile : Profile
    {
        //public override string ProfileName => base.ProfileName;
        public CustomMappingProfile()
        {
            // DTO mappinglerini buraya yazacağız
            // UserForLoginDto örnek olarak var.
            // user kaydederken farklı nesneler  gönderip insert ederken User nesnesine cevirmek için mapping yapıyoruz.
            //CreateMap<User, UserForLoginDto>();
            //CreateMap<UserForLoginDto, User>();
        }
    }
}