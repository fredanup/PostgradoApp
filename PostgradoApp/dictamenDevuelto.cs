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
    public partial class dictamenDevuelto : Form
    {
        POSTGRADODBEntities db;
        public dictamenDevuelto(TDICTAMEN_DEVUELTO obj1,TDICTAMEN_INGRESADO obj2)
        {
            InitializeComponent();
            tDICTAMENDEVUELTOBindingSource.DataSource = obj1;
            tDICTAMENINGRESADOBindingSource.DataSource = obj2;
            fechaEntregaDatePicker.Value = DateTime.Now;
            
        }

        public TDICTAMEN_DEVUELTO dictamenDevueltoInfo
        {
            get
            {
                return tDICTAMENDEVUELTOBindingSource.Current as TDICTAMEN_DEVUELTO;
            }
        }
        public TDICTAMEN_INGRESADO dictamenIngresadoInfo
        {
            get
            {
                return tDICTAMENINGRESADOBindingSource.Current as TDICTAMEN_INGRESADO;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dictamenDevueltoInfo.id_dictamen = dictamenIngresadoInfo.id;
                dictamenDevueltoInfo.nombre_destinatario = nombreTxtBox.Text;
                dictamenDevueltoInfo.apPaterno_destinatario = apPaternoTxtBox.Text;
                dictamenDevueltoInfo.apMaterno_destinatario = apMaternoTxtBox.Text;
                dictamenDevueltoInfo.fecha_entrega = fechaEntregaDatePicker.Value;
                tDICTAMENDEVUELTOBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void Enter1(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == "Nombre")
            {
                nombreTxtBox.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (nombreTxtBox.Text == string.Empty)
            {
                nombreTxtBox.Text = "Nombre";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (apPaternoTxtBox.Text == "Apellido paterno")
            {
                apPaternoTxtBox.Text = string.Empty;
            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (apPaternoTxtBox.Text == string.Empty)
            {
                apPaternoTxtBox.Text = "Apellido paterno";
            }
        }

        void Enter3(object sender, EventArgs e)
        {
            if (apMaternoTxtBox.Text == "Apellido materno")
            {
                apMaternoTxtBox.Text = string.Empty;
            }
        }
        void Leave3(object sender, EventArgs e)
        {
            if (apMaternoTxtBox.Text == string.Empty)
            {
                apMaternoTxtBox.Text = "Apellido materno";
            }
        }

    }
}
