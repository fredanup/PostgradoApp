using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PostgradoApp
{
    public partial class docenteNuevo : Form
    {
        public docenteNuevo(TDOCENTE obj)
        {
            InitializeComponent();
            
            tDOCENTEBindingSource.DataSource = obj;
            if (obj.nombre!= null)
            {
                nombreTxtBox.Text = obj.nombre;
                apPaternoTxtBox.Text = obj.apPaterno;
                apMaternoTxtBox.Text = obj.apMaterno;
                telefonoTxtBox.Text = obj.telefono_fijo;
                correoTxtBox.Text = obj.correo;
            }
        }
        public TDOCENTE docenteInfo
        {
            get
            {
                return tDOCENTEBindingSource.Current as TDOCENTE;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            docenteInfo.nombre = nombreTxtBox.Text;
            docenteInfo.apPaterno = apPaternoTxtBox.Text;
            docenteInfo.apMaterno = apMaternoTxtBox.Text;
            docenteInfo.telefono_fijo = telefonoTxtBox.Text;
            docenteInfo.correo = correoTxtBox.Text;
            tDOCENTEBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter1(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Nombre")
            {
                nombreTxtBox.Text = string.Empty;                
            }
     
        }

        private void Enter2(object sender, EventArgs e)
        {
            if (apPaternoTxtBox.Text == "Apellido paterno")
            {
                apPaternoTxtBox.Text = string.Empty;
            }

        }

        private void Enter3(object sender, EventArgs e)
        {
            if (apMaternoTxtBox.Text == "Apellido materno")
            {
                apMaternoTxtBox.Text = string.Empty;
            }
        }

        private void Enter4(object sender, EventArgs e)
        {
            if (telefonoTxtBox.Text == "Teléfono fijo")
            {
                telefonoTxtBox.Text = string.Empty;
            }
        }

        private void Enter5(object sender, EventArgs e)
        {
            if (correoTxtBox.Text == "Correo")
            {
                correoTxtBox.Text = string.Empty;
            }
        }

        private void Enter6(object sender, EventArgs e)
        {
            if (celularTxtBox.Text == "Móvil")
            {
                celularTxtBox.Text = string.Empty;
            }
        }


        private void Leave1(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == string.Empty)
            {
                nombreTxtBox.Text = "Nombre";
            }
        }

        private void Leave2(object sender, EventArgs e)
        {
            if (apPaternoTxtBox.Text==string.Empty)
            {
                apPaternoTxtBox.Text = "Apellido paterno";
            }
        }

        private void Leave3(object sender, EventArgs e)
        {

            if (apMaternoTxtBox.Text==string.Empty)
            {
                apMaternoTxtBox.Text = "Apellido materno";
            }
        }

        private void Leave4(object sender, EventArgs e)
        {
            if (telefonoTxtBox.Text==string.Empty)
            {
                telefonoTxtBox.Text = "Teléfono fijo";
            }
        }

        private void Leave5(object sender, EventArgs e)
        {
            if (correoTxtBox.Text==string.Empty)
            {
                correoTxtBox.Text = "Correo";
            }
        }

        private void Leave6(object sender, EventArgs e)
        {
            if (celularTxtBox.Text==string.Empty)
            {
                celularTxtBox.Text = "Móvil";
            }
        }

        private void apMaternoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
