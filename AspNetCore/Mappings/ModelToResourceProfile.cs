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
        }
    }
}