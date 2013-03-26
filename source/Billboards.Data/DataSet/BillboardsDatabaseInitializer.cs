using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Billboards.Data;
using Billboards.Data.Xml;
using Billboards.Data.Configuration;
using AutoMapper;
using Billboards.Model;

namespace Billboards.Data.DataSet
{
    /// <summary>
    /// 
    /// </summary>
    public class BillboardsDatabaseInitializer
        : //CreateDatabaseIfNotExists<CodeCamperDbContext>      // when model is stable
        DropCreateDatabaseIfModelChanges<BillboardDbContext>    // when iterating
    {
        protected override void Seed(BillboardDbContext context)
        {
            // do the heavy seeding
            AutoMapperDomainConfiguration.Configure();

            var kmlPlacemarks = BillboardParser.ParseXml();

            foreach (var item in kmlPlacemarks)
            {
                GeocodeServiceReference.GeocodeResponse geo = BingMapsSoapService.MakeReverseGeocodeRequest(item);
                var result = geo.Results != null && geo.Results.Length > 0 ? geo.Results[0] : null;

                if (result == null) continue;

                var address = Mapper.Map<Model.Address>(geo.Results[0].Address);

                context.Addresses.Add(address);
                context.SaveChanges();

                Billboard billboard = new Billboard();
                billboard.AddressId = address.Id;
                billboard.Address = address;
                billboard.Coordinates = item.Point.coordinates;
                billboard.Longitude = item.Point.Longitude;
                billboard.Lattitude = item.Point.Lattitude;
                billboard.DisplayName = address.FormattedAddress;
                billboard.Fid = item.ExtendedData[2].value;
                billboard.Type = item.ExtendedData[3].value;

                context.Billboards.Add(billboard);

            }
            context.SaveChanges();

        }
    }




}
