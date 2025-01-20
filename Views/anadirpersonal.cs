using Newtonsoft.Json;
using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Dtos.Staff;
using RoomBox___DataPortal.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBox___DataPortal.Views
{
    public partial class anadirpersonal : UserControl
    {
        private List<Staff> _staffs = new List<Staff>();
        private Staff _currentStaff;
        private Staff tmpStaff;
        public anadirpersonal()
        {
            InitializeComponent();
        }

        private bool isFormComplete()
        {
            bool condition = !(String.IsNullOrWhiteSpace(txtNombre.Text) ||
                                String.IsNullOrWhiteSpace(txtApellido.Text) ||
                                String.IsNullOrWhiteSpace(txtCedula.Text) ||
                                String.IsNullOrWhiteSpace(txtDireccion.Text) ||
                                String.IsNullOrWhiteSpace(txtTelefono.Text) ||
                                String.IsNullOrWhiteSpace(txtCorreo.Text)) ||
                                String.IsNullOrWhiteSpace(txtEmployeeNo.Text);
            return condition;
        }

        private async Task<List<Staff>> getStaff()
        {
            bool keepGoing = true;
            int counter = 1;
            StaffResponse res;
            List<Staff> staff = new List<Staff>();

            Api http = Api.getInstance();
            while (keepGoing)
            {
                res = await http.tryGetStaff(counter);
                if (res != null)
                {
                    foreach (Staff staf in res.Results)
                    {
                        staff.Add(staf);
                    }
                    if (res.Next != null)
                    {
                        counter++;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    keepGoing = false;
                }
            }

            return staff;
        }

        private async void anadirpersonal_Load(object sender, EventArgs e)
        {
            _staffs = await getStaff();
            refreshTable();
        }

        private void refreshTable()
        {
            tbl_Perfiles.DataSource = _staffs;
            tbl_Perfiles.ReadOnly = true;
            tbl_Perfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Perfiles.MultiSelect = false;
            tbl_Perfiles.Refresh();
        }

        private void tbl_Perfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (tbl_Perfiles.SelectedRows.Count > 0)
            {
                _currentStaff = _staffs[tbl_Perfiles.SelectedRows[0].Index];

                // Textos
                txtNombre.Text = _currentStaff.StaffName;
                txtApellido.Text = _currentStaff.StaffLastName;
                txtEmployeeNo.Text = _currentStaff.StaffEmployeeNo;
                txtCedula.Text = _currentStaff.StaffIdentification;
                txtTelefono.Text = _currentStaff.StaffPhone;
                txtDireccion.Text = _currentStaff.StaffAddress;
                txtCorreo.Text = _currentStaff.StaffEmail;

                btnRegistrar.Enabled = true;
                btnModificar.Enabled = true;
                btnCambiarEstado.Enabled = true;

            }
            else
            {
                _currentStaff = null;
                btnModificar.Enabled = false;
                btnCambiarEstado.Enabled = false;
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmployeeNo.Clear();
                txtCedula.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtCorreo.Clear();
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (!isFormComplete())
            {
                MessageBox.Show("Por favor complete todos los campos para registrar el articulo", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Staff nuevoStaff = new Staff();
            nuevoStaff.StaffName = txtNombre.Text;
            nuevoStaff.StaffLastName = txtApellido.Text;
            nuevoStaff.StaffEmployeeNo = txtEmployeeNo.Text;
            nuevoStaff.StaffDoctype = "Cedula";
            nuevoStaff.StaffIdentification = txtCedula.Text;
            nuevoStaff.StaffAddress = txtDireccion.Text;
            nuevoStaff.StaffPhone = txtTelefono.Text;
            nuevoStaff.StaffEmail = txtCorreo.Text;
            nuevoStaff.StaffStatus = true;

            Api http = Api.getInstance();
            result = await http.tryCreateStaff(nuevoStaff);

            if (result == true)
            {
                MessageBox.Show($"Se ha registrado el empleado con exito!", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _staffs = await getStaff();
                refreshTable();
            }
            else
            {
                MessageBox.Show($"No se ha podido registrar el empleado, por favor intentelo nuevamente", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            Staff tmpStaff = _currentStaff.Snapshot();
            tmpStaff.StaffStatus = !tmpStaff.StaffStatus;
            Api http = Api.getInstance();
            tmpStaff = await http.trySwitchStatusStaff(tmpStaff.StaffId, tmpStaff.StaffStatus);

            if (tmpStaff != null && tmpStaff.StaffStatus != _currentStaff.Snapshot().StaffStatus)
            {
                _staffs = await getStaff();
                refreshTable();
                if (tmpStaff.StaffStatus)
                {
                    MessageBox.Show("Se ha habilitado el empleado con exito", "Habilitacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha deshabilitado el empleado con exito", "Deshabilitacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se pudo procesar su transaccion", "Modificacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void anadirpersonal_Enter(object sender, EventArgs e)
        {
            _staffs = await getStaff();
            refreshTable();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            bool result = false;
            tmpStaff = _currentStaff.Snapshot();
            Staff updatedStaff = null;

            if (!isFormComplete())
            {
                MessageBox.Show("Por favor complete todos los campos para registrar el articulo", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tmpStaff.StaffName = txtNombre.Text;
            tmpStaff.StaffLastName = txtApellido.Text;
            tmpStaff.StaffEmployeeNo = txtEmployeeNo.Text;
            tmpStaff.StaffIdentification = txtCedula.Text;
            tmpStaff.StaffAddress = txtDireccion.Text;
            tmpStaff.StaffPhone = txtTelefono.Text;
            tmpStaff.StaffEmail = txtCorreo.Text;
            tmpStaff.StaffStatus = true;

            if (JsonConvert.SerializeObject(tmpStaff) == JsonConvert.SerializeObject(_currentStaff.Snapshot()))
            {
                MessageBox.Show("No ha modificado ningun campo en el formulario, por favor haga algun cambio y vuelva a intentarlo", "Articulo no ha sido modificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Api http = Api.getInstance();
            updatedStaff = await http.tryUpdateStaff(tmpStaff);

            if (updatedStaff != null)
            {
                MessageBox.Show($"Se ha modificado el empleado '{updatedStaff.StaffName} {updatedStaff.StaffLastName}' con exito! ID:{updatedStaff.StaffId}", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _staffs = await getStaff();
                refreshTable();
            }
            else
            {
                MessageBox.Show($"No se ha podido modificar el empleado, por favor intentelo nuevamente", "Modificacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
