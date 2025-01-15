using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBox___DataPortal.Service
{
    public sealed class Api
    {
        private readonly HttpClient _httpClient;
        private static Api _instance;
        private string _accessToken { get; set; }
        private string _refreshToken { get; set; }

        private Api()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]!);
        }

        public static Api getInstance()
        {
            if (_instance == null)
            {
                _instance = new Api();
            }
            return _instance;
        }

        public async Task<LoginResponse> tryLogin(string username, string password)
        {
            LoginRequest loginRequest = new LoginRequest()
            {
                user_name = username,
                password = password
            };

            var data = JsonConvert.SerializeObject(loginRequest);
            var jsonRequest = new StringContent(data, Encoding.UTF8, "application/json");

            try
            {
                var res = await _httpClient.PostAsync("/api/auth/login/", jsonRequest);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                LoginResponse resInfo = JsonConvert.DeserializeObject<LoginResponse>(resContent);
                _accessToken = resInfo.access;
                _refreshToken = resInfo.refresh;
                return resInfo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ArticlesResponse> tryGetArticles()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/articles/");
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            try
            {
                var res = await _httpClient.SendAsync(request);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                return ArticlesResponse.FromJson(resContent);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
