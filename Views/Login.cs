using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Service;
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
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string clave = txtClave.Text;
            Api http = Api.getInstance();

            btnIniciarSesion.Enabled = false;
            LoginResponse loginResult = await http.tryLogin(username, clave);

            if (loginResult == null)
            {
                MessageBox.Show("Por favor compruebe las credenciales e intente de nuevo", "Inicio de sesion fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIniciarSesion.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Inicio de sesion exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (Dashboard dashboard = new Dashboard(loginResult))
            {
                this.Hide();
                DialogResult result = dashboard.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            this.Show();
            btnIniciarSesion.Enabled = true;
        }

    }
}
