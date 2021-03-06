#nullable disable
using AutoMapper;
using API.Entities;
using API.DTOs.ProductType;
using API.DTOs.Product;
using API.DTOs.Category;
using API.DTOs.Auth;
using API.DTOs.User;

namespace API.Configurations;

public class CommerceProfile : Profile
{
    public CommerceProfile()
    {
        CreateMap<Category, CategoryCreateDto>().ReverseMap();
        CreateMap<Category, CategoryReadDto>().ReverseMap();
        CreateMap<Category, CategoryDetailDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();

        CreateMap<ProductType, ProductTypeCreateDto>().ReverseMap();
        CreateMap<ProductType, ProductTypeReadDto>()
            .ForMember(dest => dest.CategorySlug, opt => opt.MapFrom(src => src.Category.Slug))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
        CreateMap<ProductType, ProductTypeDetailDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
            .ForMember(dest => dest.CategorySlug, opt => opt.MapFrom(src => src.Category.Slug));
        CreateMap<ProductType, ProductTypeUpdateDto>().ReverseMap();

        CreateMap<Product, ProductCreateDto>().ReverseMap();
        CreateMap<Product, ProductReadDto>()
            .ForMember(dest => dest.ProductTypeName, opt => opt.MapFrom(src => src.ProductType.Name))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.DefaultImage, opt => opt.MapFrom(src => src.Images.ToArray()[0]));
        CreateMap<Product, ProductDetailDto>()
            .ForMember(dest => dest.DefaultImage, opt => opt.MapFrom(src => src.Images.ToArray()[0]))
            .ForMember(dest => dest.CategorySlug, opt => opt.MapFrom(src => src.Category.Slug))
            .ForMember(dest => dest.ProductTypeSlug, opt => opt.MapFrom(src => src.ProductType.Slug));

        CreateMap<User, UserRegisterDto>().ReverseMap();
        CreateMap<User, UserLoginDto>().ReverseMap();
        CreateMap<User, UserReadDto>().ReverseMap();
    }
}