using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
namespace PostgradoApp
{
    public partial class docente : UserControl
    {
        POSTGRADODBEntities db;
        public docente()
        {
            InitializeComponent();
        }


        private async void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            using (docenteNuevo docenteNuevo = new docenteNuevo(new TDOCENTE()))
            {
                if (docenteNuevo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tDOCENTEBindingSource.Add(docenteNuevo.docenteInfo);
                        db.TDOCENTE.Add(docenteNuevo.docenteInfo);
                        await db.SaveChangesAsync();

                    }
                    catch (DbEntityValidationException ex)
                    {

                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
        }

       

        private async void btnEditarDocente_Click(object sender, EventArgs e)
        {
            TDOCENTE obj = tDOCENTEBindingSource.Current as TDOCENTE;
            if (obj != null)
            {
                using(docenteNuevo nuevoDocente=new docenteNuevo(obj))
                {
                    if (nuevoDocente.ShowDialog()==DialogResult.OK)
                    {
                        try
                        {
                            
                            tDOCENTEBindingSource.EndEdit();
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
            tDOCENTEBindingSource.DataSource = db.TDOCENTE.ToList();
        }

        private void docente_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void buscarTxtBox_Click(object sender, EventArgs e)
        {

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
                var query = (from o in db.TDOCENTE
                             where o.apPaterno.StartsWith(searchValue)
                             select o).ToList();
                tDOCENTEBindingSource.DataSource = query;
                
            }
        }
    }
}
