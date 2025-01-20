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
        public anadirpersonal()
        {
            InitializeComponent();
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
            var resStaff = await getStaff();
            _staffs = resStaff;

            tbl_Perfiles.DataSource = _staffs;
            tbl_Perfiles.ReadOnly = true;
            tbl_Perfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Perfiles.MultiSelect = false;
            tbl_Perfiles.Refresh();
        }
    }
}
