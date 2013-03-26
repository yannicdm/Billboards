using AutoMapper;

namespace Billboards.Data.Configuration
{
    public static class AutoMapperDomainConfiguration
    {
        public static void Configure()
        {
            ConfigureDomainMapping();
        }

        private static void ConfigureDomainMapping()
        {
            //Mapper.CreateMap<Billboards.Model.Address, Billboards.Data.GeocodeServiceReference.Address>();

            //Mapper.CreateMap<Billboards.Model.GeocodeResult, Billboards.Data.GeocodeServiceReference.GeocodeResult>()
            //    .ForMember(b => b.Address,
            //    m => m.MapFrom
            //        (
            //        q => Mapper.Map<Billboards.Model.Address, Billboards.Data.GeocodeServiceReference.Address>(q.Address)
            //        )
            //    );

            //Mapper.CreateMap<Billboards.Model.Placemark, Billboards.Data.Xml.kmlPlacemark>()
            //    .ForMember(b => b.Point,
            //    m => m.MapFrom
            //        (
            //        q => Mapper.Map<Billboards.Model.PlacemarkPoint, Billboards.Data.Xml.kmlPlacemarkPoint>(q.Point)
            //        )
            //    )
            //    .ForMember(b => b.ExtendedData,
            //    m => m.MapFrom
            //        (
            //        q => Mapper.Map<Billboards.Model.kmlPlacemarkData[], Billboards.Data.Xml.kmlPlacemarkData[]>(q.ExtendedData)
            //        )
            //    );

            //Mapper.CreateMap<Billboards.Model.PlacemarkPoint, Billboards.Data.Xml.kmlPlacemarkPoint>();
            //Mapper.CreateMap<Billboards.Model.kmlPlacemarkData, Billboards.Data.Xml.kmlPlacemarkData>();
            //Mapper.CreateMap<Billboards.Model.Billboard, Billboards.Model.BillboardBrief>();


            Mapper.CreateMap<GeocodeServiceReference.Address, Model.Address>();

      
        }
    }
}
