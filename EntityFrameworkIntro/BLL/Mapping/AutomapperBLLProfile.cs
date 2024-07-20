using AutoMapper;
using BLL.Models.AddEntityModels;
using BLL.Models.GetEntityModels;
using BLL.Models.UpdateEntityModel;
using DataLayer.Entities;

namespace BLL.Mapping
{
    public class AutomapperBLLProfile : Profile
    {
        public AutomapperBLLProfile()
        {
            CreateMap<Shop, ShopReadModel>()
                .ForMember(
                    dest => dest.ShopId,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.PointName,
                    opt => opt.MapFrom(src => src.PointName))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Items,
                    opt => opt.MapFrom(src => src.Items))
                .ForMember(
                    dest => dest.ManagerId,
                    opt => opt.MapFrom(src => src.ManagerId)).ReverseMap();

            CreateMap<Shop, SaveShopModel>()
                .ForMember(
                    dest => dest.PointName,
                    opt => opt.MapFrom(src => src.PointName))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Items,
                    opt => opt.Ignore())
                .ForMember(
                    dest => dest.ManagerId,
                    opt => opt.MapFrom(src => src.ManagerId)).ReverseMap();

            CreateMap<Shop, UpdateShopModel>()
                .ForMember(
                    dest => dest.ShopId,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.PointName,
                    opt => opt.MapFrom(src => src.PointName))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Items,
                    opt => opt.Ignore())
                .ForMember(
                    dest => dest.ManagerId,
                    opt => opt.MapFrom(src => src.ManagerId)).ReverseMap();

            CreateMap<Item, ItemModel>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.ShopId,
                    opt => opt.MapFrom(src => src.ShopId))
                .ForMember(
                    dest => dest.ItemId,
                    opt => opt.MapFrom(src => src.Id)).ReverseMap();

        }
    }
}
