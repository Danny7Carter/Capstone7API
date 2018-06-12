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
        //Both method and your return have to 
        //return the same return type List<string>
        public List<string> GetProductID()
        {
            NorthwindEntities db = new NorthwindEntities();
            //pull your own name in the for loop
            //pID is a database full of tables
            List<Product> pID =  db.Products.ToList();
            //Creating a list of strings (generic) 
            //throwing in data from your list of products db.
            List<string> names = new List<string>();

            //pID.Count it's not just numbers so we use 
            //.Count(counting index)to go through the list of data
            for (int i = 0; i < pID.Count; i++)
            {
                //"names" is the list of names I want to put data into
                //[i] is the index. This will grab everything
                //. allows you to join 'objects'
                names.Add(pID[i].ProductID.ToString());
                //ToString not needed because 'ProductName"
                //is already a string.
                names.Add(pID[i].ProductName);

                
            }
            
            return names;
        }

        public Product GetProductID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            Product prod = (from p in db.Products
                            where p.ProductID == id
                            select p).Single();
            //if (db.Database == null)
            //{
            //        return;
            //}

            return prod;
        }

    }
}
