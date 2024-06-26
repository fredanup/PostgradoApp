using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgradoApp
{
    public partial class alumno : UserControl
    {
        POSTGRADODBEntities db;
        public alumno()
        {
            InitializeComponent();
        }

        private async void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            using (alumnoNuevo alumnoNuevo = new alumnoNuevo(new TALUMNO()))
            {
                if (alumnoNuevo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tALUMNOBindingSource.Add(alumnoNuevo.alumnoInfo);
                        db.TALUMNO.Add(alumnoNuevo.alumnoInfo);
                        await db.SaveChangesAsync();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
        private async void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            TALUMNO obj = tALUMNOBindingSource.Current as TALUMNO;
            if (obj != null)
            {
                using (alumnoNuevo nuevoAlumno  = new alumnoNuevo(obj))
                {
                    if (nuevoAlumno.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            tALUMNOBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                            cargarGrilla();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void cargarGrilla()
        {
            db = new POSTGRADODBEntities();
            tALUMNOBindingSource.DataSource = db.TALUMNO.ToList();
        }
        private void alumno_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        void Enter1(object sender, EventArgs e)
        {
            if (buscarTxtBox.Text == "Buscar por apellido")
            {
                buscarTxtBox.Text = string.Empty;
                label2.Text = "Buscar por apellido";
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (buscarTxtBox.Text == string.Empty)
            {
                buscarTxtBox.Text = "Buscar por apellido";
                label2.Text = string.Empty;
            }
        }
        private void buscarTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (buscarTxtBox.Text != "Buscar por apellido")
            {
                var searchValue = buscarTxtBox.Text.Trim();//you can add a ToUpper();
                var query = (from o in db.TALUMNO
                             where o.apPaterno.StartsWith(searchValue)
                             select o).ToList();
                tALUMNOBindingSource.DataSource = query;
 
            }
        }
    }
}
