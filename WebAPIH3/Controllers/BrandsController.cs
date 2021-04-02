using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIH3.Models;

namespace WebAPIH3.Controllers
{
    public class BrandsController : ApiController
    {
        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId="B001",Name="Haro"},
            new Brand(){BrandId="B002",Name="Electra"},
            new Brand(){BrandId="B003",Name="Heller"},
            new Brand(){BrandId="B004",Name="Treck"}

        };
        public HttpResponseMessage Post([FromUri] Brand brand)
        {
            using (WebAPIContext conn = new WebAPIContext())
            {
                conn.Brands.Add(brand);
                conn.SaveChanges();
                var msg = Request.CreateResponse(HttpStatusCode.Created, brand);
                return msg;
            }
        }
    }
}
