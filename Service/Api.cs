using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Dtos.ArticleFrequency;
using RoomBox___DataPortal.Dtos.GetUsuarios;
using RoomBox___DataPortal.Dtos.MonthlySales;
using RoomBox___DataPortal.Dtos.Staff;
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

        public void clearToken()
        {
            _accessToken = null;
            _refreshToken = null;
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
                //_httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_accessToken}");
                return resInfo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ArticlesResponse> tryGetArticles(int page)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/articles/?page={page}");
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

        public async Task<ArticlesResponse> tryGetAdminUsers(int page)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/staff/?page={page}");
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

        public async Task<Article> trySwitchStatusArticle(int articleId, bool newStatus)
        {

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {

                formData.Add(new StringContent(newStatus.ToString()), "article_status");

                var request = new HttpRequestMessage(HttpMethod.Patch, $"/api/articles/{articleId}/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
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
                if (article.ArticleDescription != null) formData.Add(new StringContent(article.ArticleDescription.ToString()!), "article_description");
                if (article.ArticleType != null) formData.Add(new StringContent(article.ArticleType.ToString()!), "article_type");
                if (article.ArticleUnitPrice != null) formData.Add(new StringContent(article.ArticleUnitPrice.ToString()!), "article_unit_price");
                formData.Add(new StringContent(article.ArticleStatus.ToString()!), "article_status");
                //formData.Add(new StringContent("1"), "client");

                var request = new HttpRequestMessage(HttpMethod.Post, "/api/articles/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
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

        public async Task<List<ArticleFrequencyResponse>> tryGetFrequency(int articleId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/articles/order_frequency/?ordering=total_quantity_ordered");
            if (articleId != 0)
            {
                request = new HttpRequestMessage(HttpMethod.Get, $"/api/articles/order_frequency/?ordering=total_quantity_ordered&article_id={articleId}");
            }
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            try
            {
                var res = await _httpClient.SendAsync(request);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                if (articleId == 0)
                {
                    return ArticleFrequencyResponse.FromJson(resContent);
                } else
                {
                    return new List<ArticleFrequencyResponse>() { ArticleFrequencyResponse.FromJsonUnique(resContent) };
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<MonthlySales>> tryGetMonthlySales()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/orders/monthly_sales/");
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            try
            {
                var res = await _httpClient.SendAsync(request);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                return MonthlySales.FromJson(resContent);
            }
            catch (Exception e)
            {
                return null;
            }
        }

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
                if (article.ArticleDescription != null) formData.Add(new StringContent(article.ArticleDescription.ToString()!), "article_description");
                if (article.ArticleType != null) formData.Add(new StringContent(article.ArticleType.ToString()!), "article_type");
                formData.Add(new StringContent(article.ArticleStock.ToString()!), "article_stock");
                if (article.ArticleUnitPrice != null) formData.Add(new StringContent(article.ArticleUnitPrice.ToString()!), "article_unit_price");
                formData.Add(new StringContent(article.ArticleStatus.ToString()!), "article_status");
                formData.Add(new StringContent(article.ArticleId.ToString()!), "article_id");


                var request = new HttpRequestMessage(HttpMethod.Patch, $"/api/articles/{article.ArticleId}/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
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

        public async Task<StaffResponse> tryGetStaff(int page)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/staff/?page={page}");
            request.Headers.Add("Authorization", $"Bearer {_accessToken}");

            try
            {
                var res = await _httpClient.SendAsync(request);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                return StaffResponse.FromJson(resContent);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Boolean> tryCreateStaff(Staff staffToCreate)
        {

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(staffToCreate.StaffName.ToString()!), "staff_name");
                formData.Add(new StringContent(staffToCreate.StaffLastName.ToString()!), "staff_last_name");
                formData.Add(new StringContent(staffToCreate.StaffEmployeeNo.ToString()!), "staff_employee_no");
                formData.Add(new StringContent(staffToCreate.StaffIdentification.ToString()!), "staff_identification");
                formData.Add(new StringContent(staffToCreate.StaffDoctype.ToString()!), "staff_doctype");
                formData.Add(new StringContent(staffToCreate.StaffAddress.ToString()!), "staff_address");
                formData.Add(new StringContent(staffToCreate.StaffPhone.ToString()!), "staff_phone");
                formData.Add(new StringContent(staffToCreate.StaffEmail.ToString()!), "staff_email");
                formData.Add(new StringContent(staffToCreate.StaffStatus.ToString()!), "staff_status");
                //formData.Add(new StringContent("1"), "client");

                var request = new HttpRequestMessage(HttpMethod.Post, "/api/staff/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
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
            }

        }

        public async Task<Staff> trySwitchStatusStaff(int staffId, bool newStatus)
        {

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {

                formData.Add(new StringContent(newStatus.ToString()), "staff_status");

                var request = new HttpRequestMessage(HttpMethod.Patch, $"/api/staff/{staffId}/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
                    if (res.IsSuccessStatusCode)
                    {
                        var resContent = await res.Content.ReadAsStringAsync();
                        return Staff.FromJson(resContent);
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

        public async Task<Staff> tryUpdateStaff(Staff staff)
        {
            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(staff.StaffName.ToString()!), "staff_name");
                formData.Add(new StringContent(staff.StaffLastName.ToString()!), "staff_last_name");
                formData.Add(new StringContent(staff.StaffEmployeeNo.ToString()!), "staff_employee_no");
                formData.Add(new StringContent(staff.StaffIdentification.ToString()!), "staff_identification");
                formData.Add(new StringContent(staff.StaffDoctype.ToString()!), "staff_doctype");
                formData.Add(new StringContent(staff.StaffAddress.ToString()!), "staff_address");
                formData.Add(new StringContent(staff.StaffPhone.ToString()!), "staff_phone");
                formData.Add(new StringContent(staff.StaffEmail.ToString()!), "staff_email");
                formData.Add(new StringContent(staff.StaffStatus.ToString()!), "staff_status");


                var request = new HttpRequestMessage(HttpMethod.Patch, $"/api/staff/{staff.StaffId}/");
                request.Headers.Add("Authorization", $"Bearer {_accessToken}");
                request.Content = formData;

                try
                {
                    var res = await _httpClient.SendAsync(request);
                    if (res.IsSuccessStatusCode)
                    {
                        var resContent = await res.Content.ReadAsStringAsync();
                        return Staff.FromJson(resContent);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;

                } // End of try catch

            } // End of using

        } // End of method

    }
}
