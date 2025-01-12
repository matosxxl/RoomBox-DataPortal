using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using System.Configuration;
using System.Text;
using System.Text.Json.Serialization;

namespace RoomBox___DataPortal
{
    public partial class Login : Form
    {
        private readonly HttpClient _httpClient;
        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]!);
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string clave = txtClave.Text;

            LoginResponse loginResult = await tryLogin(username, clave);

            using (Dashboard dashboard = new Dashboard())
            {
                this.Hide();
                DialogResult result = dashboard.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            this.Show();
        }

        private async Task<LoginResponse> tryLogin (string username, string password)
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
                var res = await _httpClient.PostAsync($"/api/auth/login/", jsonRequest);
                res.EnsureSuccessStatusCode();
                var resContent = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LoginResponse>(resContent);
            }
            catch (Exception ex)
            {
               return null;
            }
        }

    }
}
