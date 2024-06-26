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
    public partial class dictamenTotal : UserControl
    {
        public POSTGRADODBEntities db;   
        public dictamenTotal()
        {
            InitializeComponent();
        
           


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

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dictamenTotal dictamenTotal = new dictamenTotal();
  
        }


        private void btnEntregados_Click(object sender, EventArgs e)
        {
            dictamenEntregado dictamenEntregado = new dictamenEntregado();
            btnEntregados.IsTab = true;
            btnEntregados.selected = true;
            //pnlCuerpo.Controls.Clear();
            //pnlCuerpo.Controls.Add(dictamenEntregado);
        }
        private void cargarGrilla()
        {
            db = new POSTGRADODBEntities();
            tDICTAMENINGRESADOVIEWBindingSource.DataSource = db.TDICTAMEN_INGRESADOVIEW.ToList();
            tDICTAMENINGRESADOBindingSource.DataSource = db.TDICTAMEN_INGRESADO.ToList();
            dataGridDictamen.ClearSelection();
            diseñarGrilla();

        }
        private void diseñarGrilla()
        {
            for (int i = 0; i < dataGridDictamen.Rows.Count; i++)
            {

                ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[9]).Value = "Ver";
                ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[9]).FlatStyle = FlatStyle.Flat;
                ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[9]).Style.BackColor = Color.FromArgb(0, 173, 239);
                ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[9]).Style.ForeColor = Color.White;
                if (i % 2 != 0)
                {
                    dataGridDictamen.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    dataGridDictamen.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
                }
                try
                {
                    using (POSTGRADODBEntities db = new POSTGRADODBEntities())
                    {
                        int id_dictamen = Convert.ToInt32(dataGridDictamen.Rows[i].Cells[0].Value);

                        var query = from o in db.TDICTAMEN_DEVUELTO
                                    where o.id_dictamen == id_dictamen
                                    select o;

                        if (query.SingleOrDefault() != null)
                        {
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Value = "Entregado";
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).FlatStyle = FlatStyle.Flat;
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Style.BackColor = Color.Gray;
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Style.ForeColor = Color.White;

                        }
                        else
                        {
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Value = "Entregar";
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).FlatStyle = FlatStyle.Flat;
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Style.BackColor = Color.FromArgb(176, 73, 76);
                            ((DataGridViewButtonCell)dataGridDictamen.Rows[i].Cells[8]).Style.ForeColor = Color.White;
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }

            }
        }
        private async void btnNuevoDictamen_Click(object sender, EventArgs e)
        {
            using (dictamenNuevo nuevoDictamen = new dictamenNuevo(new TDICTAMEN_INGRESADO(),new TDICTAMEN_INGRESADOVIEW()))
            {
                if (nuevoDictamen.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tDICTAMENINGRESADOBindingSource.Add(nuevoDictamen.dictamenIngresadoInfo);
                        db.TDICTAMEN_INGRESADO.Add(nuevoDictamen.dictamenIngresadoInfo);
                        await db.SaveChangesAsync();
                        cargarGrilla();
                        dataGridDictamen.Rows[dataGridDictamen.Rows.Count - 1].Selected = true;
                        dataGridDictamen.CurrentCell = dataGridDictamen.Rows[dataGridDictamen.Rows.Count - 1].Cells[0];
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
        
        private async void btnEditarDictamen_Click(object sender, EventArgs e)
        {
            
            TDICTAMEN_INGRESADOVIEW obj = tDICTAMENINGRESADOVIEWBindingSource.Current as TDICTAMEN_INGRESADOVIEW;
            var query = (from o in db.TDICTAMEN_INGRESADO
                        where o.id == obj.id
                        select o);
            
            if (obj != null)
            {
                using (dictamenNuevo nuevoDictamen = new dictamenNuevo(query.SingleOrDefault(),obj))
                {
                    if (nuevoDictamen.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {                                                   
                            tDICTAMENINGRESADOBindingSource.EndEdit();
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

      

        private void dictamenTotal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
           
        }
        private void btnNoEntregados_Click(object sender, EventArgs e)
        {
            dictamenEntregado dictamenEntregado = new dictamenEntregado();
            btnEntregados.IsTab = true;
            btnEntregados.selected = true;
        }
        private async void dataGridDictamen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 8)
                {
                    TDICTAMEN_INGRESADOVIEW obj = tDICTAMENINGRESADOVIEWBindingSource.Current as TDICTAMEN_INGRESADOVIEW;
                 
                    if (obj != null)
                    {
                        var query = (from o in db.TDICTAMEN_INGRESADO
                                     where o.id == obj.id
                                     select o);
                        using (dictamenDevuelto dictamenDevuelto = new dictamenDevuelto(new TDICTAMEN_DEVUELTO(),query.SingleOrDefault()))
                        {
                            if (dictamenDevuelto.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    tDICTAMENDEVUELTOBindingSource.Add(dictamenDevuelto.dictamenDevueltoInfo);
                                    db.TDICTAMEN_DEVUELTO.Add(dictamenDevuelto.dictamenDevueltoInfo);
                                    await db.SaveChangesAsync();
                                    ((DataGridViewButtonCell)dataGridDictamen.Rows[dataGridDictamen.CurrentCell.RowIndex].Cells[8]).Value = "Entregado";
                                    ((DataGridViewButtonCell)dataGridDictamen.Rows[dataGridDictamen.CurrentCell.RowIndex].Cells[8]).Style.BackColor = Color.Gray;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                    }
                }
            }

        }

        private void buscarTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buscarTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (buscarTxtBox.Text!="Buscar por apellido")
            {
                var searchValue = buscarTxtBox.Text.Trim();//you can add a ToUpper();
                var query = (from o in db.TDICTAMEN_INGRESADOVIEW
                             where o.Alumno.StartsWith(searchValue)
                             select o).ToList();
                tDICTAMENINGRESADOVIEWBindingSource.DataSource = query;
                diseñarGrilla();
            }
        }
    }
}
