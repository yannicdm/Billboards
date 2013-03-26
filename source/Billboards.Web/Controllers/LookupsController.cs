using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Billboards.Data.Contracts;
using Billboards.Model;
using AutoMapper;

namespace Billboards.Web.Controllers
{
    public class LookupsController : ApiControllerBase
    {
         IBillboardsUow _uow;

        public LookupsController (IBillboardsUow uow)
	{
            this._uow = uow;
	}
        // GET: api/lookups/addresses
        [ActionName("addresses")]
        public IEnumerable<Address> GetAdresses()
        {
        return _uow.Addresses.GetAll().OrderBy(x => x.Locality).ThenBy(x => x.AddressLine);
        }

        // GET: api/lookups/addresses/5
        [ActionName("addresses")]
        public Address GetAdresses(int id)
        {
            return _uow.Addresses.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        // Lookups: aggregates the many little lookup lists in one payload
        // to reduce roundtrips when the client launches.
        // GET: api/lookups/all
        [ActionName("all")]
        public Lookups GetLookups()
        {
            var lookups = new Lookups()
            {
                Adresses = GetAdresses().ToList()
            };
            return lookups;
        }


    }
}
