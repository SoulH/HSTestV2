using HSTestV2.Models;
using HSTestV2.ViewModels;
using HSTestV2Api.Models.ApiResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HSTestV2.Services
{
    class ApiService : InternetService
    {
        public static string URL_BASE = "http://hstestv2api20180214100403.azurewebsites.net/";
        protected static RestClient client = new RestClient(URL_BASE);

        public static Task<AuthResponse> Auth(LoginViewModel model)
        {
            return Task.Factory.StartNew(() =>
            {
                var str = $"grant_type=password&userName={model.User}&password={model.Password}";
                var request = new RestRequest("token", Method.POST);
                request.AddHeader("Content-type", "application/x-www-form-urlencoded; charset=UTF-8");
                request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", str, ParameterType.RequestBody);
                var response = client.Execute(request);
                JObject obj = JObject.Parse(response.Content);
                if (response.IsSuccessful)
                {
                    return new AuthResponse()
                    {
                        Success = true,
                        Token = obj["access_token"].ToString()
                    };
                }
                return new AuthResponse()
                {
                    Success = false,
                    Error = obj["error"].ToString()
                };
            });
        }

        public static Task<Response> SignIn(RegisterViewModel model)
        {
            return Task.Factory.StartNew(() =>
            {
                var json = JsonConvert.SerializeObject(model);
                var request = new RestRequest("api/account/register", Method.POST);
                request.AddHeader("Content-type", "application/json; charset=UTF-8");
                request.AddParameter("application/json; charset=UTF-8", json);
                var response = client.Execute<Response>(request);
                if (response.IsSuccessful)
                    return response.Data;
                return new Response() { Success = false };
            });
        }

    }
}
