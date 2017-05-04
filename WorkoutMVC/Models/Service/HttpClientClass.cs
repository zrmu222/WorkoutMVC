using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Configuration;


namespace WorkoutMVC.Models.Service
{
    public class HttpClientClass
    {
        HttpClient client;

        public HttpClientClass()
        {
            client = new HttpClient();
            string uri = getUri();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpClient getClient()
        {
            return client;
        }

        private string getUri()
        {
            string uriString = ConfigurationManager.AppSettings["Uri"];
            return uriString;
        }


    }
}