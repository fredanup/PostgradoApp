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
    public partial class dictamenIngresado : UserControl
    {
        public dictamenIngresado()
        {
            InitializeComponent();
            dataGridDictamen.Rows.Add( "20/07/2018", "Si", "Entregar");
           

            ((DataGridViewButtonCell)dataGridDictamen.Rows[0].Cells[3]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)dataGridDictamen.Rows[0].Cells[3]).Style.BackColor = Color.FromArgb(176, 73, 76);
            ((DataGridViewButtonCell)dataGridDictamen.Rows[0].Cells[3]).Style.ForeColor = Color.White;


        }
    }
}
