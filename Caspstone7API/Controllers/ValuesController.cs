using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Caspstone7API.Models;

namespace Caspstone7API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        public List<Product> GetProductID()
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> pID =  db.Products.ToList();
                                
            return pID;
        }

        public List<Product> GetProductID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> pID = db.Products.ToList();
                                (from p in db.Products
                             where p.ProductID == (id)
                             select p).Single();

            return pID;
        }

    }
}
