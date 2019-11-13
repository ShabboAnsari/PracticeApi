using AutoMapper;
using PracticeApi.Models;
using PracticeApi.ViewModels;

namespace PracticeApi.Mappings
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Blogs, BlogResource>();
            CreateMap<Contacts, ContactResorce>();
            CreateMap<Pages, PageResorce>();
            CreateMap<User, UserResource>();
            CreateMap<Products, ProductResorce>();
        }
    }
}