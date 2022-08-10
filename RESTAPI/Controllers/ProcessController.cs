using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTAPI.Controllers
{
    class Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
    public class ProcessController : ApiController
    {
        public HttpResponseMessage Get()
        {
            List<Model> ob = new List<Model>();
            ob.Add(new Model { ID = 1, FirstName = "A", LastName = "A" });
            ob.Add(new Model { ID = 2, FirstName = "B", LastName = "B" });
            ob.Add(new Model { ID = 3, FirstName = "C", LastName = "C" });

            //Serializing to Json String:
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(ob);

            //Deserializing to Object:
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model>>(jsonString);

            return Request.CreateResponse(HttpStatusCode.OK, ob);
        }
        public HttpResponseMessage Put(int ID)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Put Method");
        }

        public HttpResponseMessage Post(int ID)
        {
            return Request.CreateResponse(HttpStatusCode.Created, "Post Method");
        }

        public HttpResponseMessage Delete(int ID)
        {
            return Request.CreateResponse(HttpStatusCode.Accepted, "Delete Method");
        }
    }
}
