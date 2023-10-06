using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Forms.Api
{
    public class BaseApi
    {
        protected static HttpResponseMessage GetAPI(string metodo)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = ConfigurationManager.AppSettings["uri"].ToString();
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync(metodo).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        protected static HttpResponseMessage PostAPI(string metodo, object body)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = ConfigurationManager.AppSettings["uri"].ToString();
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.PostAsJsonAsync<object>(metodo, body).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        protected static HttpResponseMessage PutAPI(string metodo, object body)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = ConfigurationManager.AppSettings["uri"].ToString();
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.PutAsJsonAsync<object>(metodo, body).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        protected static HttpResponseMessage DeleteAPI(string metodo)
        {
            try
            {
                HttpClient client = new HttpClient();
                string uri = ConfigurationManager.AppSettings["uri"].ToString();
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.DeleteAsync(metodo).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
