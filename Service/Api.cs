using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
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
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_accessToken}");
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

        public async Task<Article> trySwitchStatusArticle(int articleId, bool newStatus)
        {

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {

                formData.Add(new StringContent(newStatus.ToString()), "article_status");

                try
                {
                    var res = await _httpClient.PatchAsync($"/api/articles/{articleId}/", formData);
                    if (res.IsSuccessStatusCode)
                    {
                        var resContent = await res.Content.ReadAsStringAsync();
                        return Article.FromJson(resContent);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;

                }

            }
        }

        public async Task<Boolean> tryCreateArticle(Article article, string imagePath) 
        { 
            FileStream fs = null;

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {

                // Image handling
                if (imagePath != null)
                {
                    fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    StreamContent fileContent = new StreamContent(fs);
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                    formData.Add(fileContent, "image", Path.GetFileName(imagePath));
                }

                if (article.ArticleName != null) formData.Add(new StringContent(article.ArticleName.ToString()!), "article_name");
                formData.Add(new StringContent(article.ArticleStock.ToString()!), "article_stock");
                if (article.ArticleUnitPrice != null) formData.Add(new StringContent(article.ArticleUnitPrice.ToString()!), "article_unit_price");
                formData.Add(new StringContent(article.ArticleStatus.ToString()!), "article_status");
                formData.Add(new StringContent("1"), "client");

                try
                {
                    var res = await _httpClient.PostAsync($"/api/articles/", formData);
                    if (res.StatusCode == HttpStatusCode.Created)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;

                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                        fs.Dispose();
                    }
                } // End of try catch

            } // End of using

        } // End of method

        public async Task<Article> tryUpdateArticle(Article article, string imagePath)
        {
            FileStream fs = null;

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {

                // Image handling
                if (imagePath != null)
                {
                    fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    StreamContent fileContent = new StreamContent(fs);
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                    formData.Add(fileContent, "image", Path.GetFileName(imagePath));
                }

                if (article.Client != null) formData.Add(new StringContent(article.Client.ToString()!), "client");
                if (article.ArticleName != null) formData.Add(new StringContent(article.ArticleName.ToString()!), "article_name");
                formData.Add(new StringContent(article.ArticleStock.ToString()!), "article_stock");
                if (article.ArticleUnitPrice != null) formData.Add(new StringContent(article.ArticleUnitPrice.ToString()!), "article_unit_price");
                formData.Add(new StringContent(article.ArticleStatus.ToString()!), "article_status");
                formData.Add(new StringContent(article.ArticleId.ToString()!), "article_id");

                try
                {
                    var res = await _httpClient.PatchAsync($"/api/articles/{article.ArticleId}/", formData);
                    if (res.IsSuccessStatusCode)
                    {
                        var resContent = await res.Content.ReadAsStringAsync();
                        return Article.FromJson(resContent);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;

                } finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                        fs.Dispose();
                    }
                } // End of try catch

            } // End of using

        } // End of method

        public async Task<GetUsuarios> tryGetStaff()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/staff/");

            try
            {
                var res = await _httpClient.SendAsync(request);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                return GetUsuarios.FromJson(resContent);
            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}
