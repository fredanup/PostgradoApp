using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgradoApp
{
    public partial class alumnoNuevo : Form
    {
        public alumnoNuevo(TALUMNO obj)
        {
            InitializeComponent();
            tALUMNOBindingSource.DataSource = obj;
            if (obj.nombre != null)
            {
                nombreTxtBox.Text = obj.nombre;
                apPaternoTxtBox.Text = obj.apPaterno;
                apMaternoTxtBox.Text = obj.apMaterno;
                telefonoTxtBox.Text = obj.telefono_fijo;
                correoTxtBox.Text = obj.correo;
            }


            dataGridDictamen.ClearSelection();
            for (int i = 0; i < dataGridDictamen.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridDictamen.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    dataGridDictamen.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public TALUMNO alumnoInfo
        {
            get
            {
                return tALUMNOBindingSource.Current as TALUMNO;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            alumnoInfo.nombre = nombreTxtBox.Text;
            alumnoInfo.apPaterno = apPaternoTxtBox.Text;
            alumnoInfo.apMaterno = apMaternoTxtBox.Text;
            alumnoInfo.telefono_fijo = telefonoTxtBox.Text;
            alumnoInfo.correo = correoTxtBox.Text;
            tALUMNOBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
        private void Enter1(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Nombres")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Enter2(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Apellido paterno")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Enter3(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Apellido materno")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Enter4(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Teléfono fijo")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Enter5(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Correo")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Enter6(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Móvil")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }

        private void Leave1(object sender, EventArgs e)
        {

        }

        private void Leave2(object sender, EventArgs e)
        {

        }

        private void Leave3(object sender, EventArgs e)
        {

        }

        private void Leave4(object sender, EventArgs e)
        {

        }

        private void Leave5(object sender, EventArgs e)
        {

        }

        private void Leave6(object sender, EventArgs e)
        {

        }
    }
}
