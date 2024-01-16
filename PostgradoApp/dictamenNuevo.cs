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
using System.Configuration;
namespace PostgradoApp
{
    public partial class dictamenNuevo : Form
    {
        POSTGRADODBEntities db;
        
        public dictamenNuevo(TDICTAMEN_INGRESADO oDICTAMEN_INGRESADO, TDICTAMEN_INGRESADOVIEW oDICTAMEN_INGRESADOVIEW)
        {
            InitializeComponent();
            tDICTAMENINGRESADOBindingSource.DataSource = oDICTAMEN_INGRESADO;
            tDICTAMENINGRESADOVIEWBindingSource.DataSource = oDICTAMEN_INGRESADOVIEW;
            fechaIngresoDatePicker.Value = DateTime.Now;
            fechaEmisionDatePicker.Value = DateTime.Now;
            cargarCombos();
            if (oDICTAMEN_INGRESADOVIEW.Alumno != null)
            {
                alumnoComboBox.SelectedValue = oDICTAMEN_INGRESADO.id_alumno;
                dictaminanteComboBox.SelectedValue = oDICTAMEN_INGRESADO.id_dictaminante;
                asuntoTxtBox.Text = oDICTAMEN_INGRESADO.asunto;
                destinatarioTxtBox.Text = oDICTAMEN_INGRESADO.destinatario;
                fechaEmisionDatePicker.Value = oDICTAMEN_INGRESADO.fecha_emision;
                fechaIngresoDatePicker.Value = oDICTAMEN_INGRESADO.fecha_ingreso;
                aptoSwitch.Value = oDICTAMEN_INGRESADO.apto;
                titlelbl.Text = "Editar dictamen";
            }
            else
            {
                titlelbl.Text = "Nuevo dictamen";
            }

        }
        public void cargarCombos()
        {
            db = new POSTGRADODBEntities();
            alumnoComboBox.DataSource = db.TALUMNOVIEW.OrderBy(o => o.Alumno).ToList();
            dictaminanteComboBox.DataSource = db.TDOCENTEVIEW.OrderBy(o=>o.Docente).ToList();
        }
        public TDICTAMEN_INGRESADO dictamenIngresadoInfo
        {
            get
            {
                return tDICTAMENINGRESADOBindingSource.Current as TDICTAMEN_INGRESADO;
            }
        }
        public TDICTAMEN_INGRESADOVIEW dictamenIngresadoViewInfo
        {
            get
            {
                return tDICTAMENINGRESADOVIEWBindingSource.Current as TDICTAMEN_INGRESADOVIEW;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dictamenIngresadoInfo.id_dictaminante = Convert.ToInt32(dictaminanteComboBox.SelectedValue);
                dictamenIngresadoInfo.id_alumno = Convert.ToInt32(alumnoComboBox.SelectedValue);
                dictamenIngresadoInfo.asunto = asuntoTxtBox.Text;
                dictamenIngresadoInfo.destinatario = destinatarioTxtBox.Text;
                dictamenIngresadoInfo.fecha_emision = fechaEmisionDatePicker.Value;
                dictamenIngresadoInfo.fecha_ingreso = fechaIngresoDatePicker.Value;
                dictamenIngresadoInfo.apto = aptoSwitch.Value;
                tDICTAMENINGRESADOBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Enter1(object sender, EventArgs e)
        {
            if (asuntoTxtBox.Text == "Asunto")
            {
                asuntoTxtBox.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (asuntoTxtBox.Text == string.Empty)
            {
                asuntoTxtBox.Text = "Asunto";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (destinatarioTxtBox.Text == "Destinatario")
            {
                destinatarioTxtBox.Text = string.Empty;
            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (destinatarioTxtBox.Text == string.Empty)
            {
                destinatarioTxtBox.Text = "Destinatario";
            }
        }

        
        private void dictaminanteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
