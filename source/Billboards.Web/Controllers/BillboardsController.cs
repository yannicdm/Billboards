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
    public class BillboardsController : ApiControllerBase
    {
        IBillboardsUow _uow;

        public BillboardsController(IBillboardsUow uow)
        {
            this._uow = uow;
        }

        // GET api/billoards
        public IEnumerable<Billboard> Get()
        {
            return _uow.Billboards.GetAll();
        }

        // GET api/billoards/5
        public BillboardBrief Get(int id)
        {
            Mapper.CreateMap<Billboard, BillboardBrief>();


            var billboard = _uow.Billboards.GetAll().Where(x => x.Id == id).FirstOrDefault();
            if (billboard != null)
                return Mapper.Map<BillboardBrief>(billboard);
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }

           // Create a new Billboard
        // POST /api/billboard
        public HttpResponseMessage Post(BillboardBrief billboard)
        {
            var response = Request.CreateResponse(HttpStatusCode.Created, billboard);

            // Compose location header that tells how to get this attendance
            // e.g. ~/api/attendance/?pid=2&sid=1
            var queryString = string.Format(
                "?id={0}", billboard.Id);
            response.Headers.Location =
                new Uri(Url.Link(WebApiConfig.ControllerOnly, null) + queryString);

            return response;
        }

        // Update an existing Billboard 
        // PUT /api/billboard/
        public HttpResponseMessage Put(Billboard billboard)
        {
            var x = billboard.Type;

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // DELETE /api/billboard/?id=2
        public HttpResponseMessage Delete(int id)
        {
       
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
        
    }
}