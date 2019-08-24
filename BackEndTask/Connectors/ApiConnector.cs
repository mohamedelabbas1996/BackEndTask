using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using BackEndTask.Models;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;

namespace BackEndTask.Connectors
{
    public class ApiConnector
    {
        private Uri BaseUrl = new Uri ("http://api.stackexchange.com/");
        private static  HttpClient httpClient;
        public ApiConnector() {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            httpClient = new HttpClient(handler);
            httpClient.BaseAddress = BaseUrl;
           httpClient.DefaultRequestHeaders.Accept.Clear();
           httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "C# App");



        }

        public async Task<Response> getAllQuestions() {

            var res = await httpClient.GetAsync("/2.2/questions?pagesize=50&order=desc&sort=creation&site=stackoverflow");
            return await res.Content.ReadAsAsync<Response>();

           

        }
            





    }
    }
