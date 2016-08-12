using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using RestSharp;

namespace MapsApi.Controllers
{
    public class DriveTimeController : ApiController
    {
        // GET: api/DriveTime
        public string Get()
        {
            var client = new RestClient("https://maps.googleapis.com/maps/api/");

            var request = new RestRequest("distancematrix/json", Method.GET);
            request.AddParameter("origins", "Seattle");
            request.AddParameter("destinations", "San Francisco");
            request.AddParameter("key", WebConfigurationManager.AppSettings["GoogleApiKey"]);

            
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            
            return content;
        }

        // GET: api/DriveTime/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DriveTime
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DriveTime/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DriveTime/5
        public void Delete(int id)
        {
        }
    }
}
