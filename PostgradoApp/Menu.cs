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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDictamen_Click(object sender, EventArgs e)
        {
            dictamenTotal dictamenTotal = new dictamenTotal();
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(dictamenTotal);
            lblTitle.Text = "Dictámenes";
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            docente docente = new docente();
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(docente);
            lblTitle.Text = "Docentes";
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            alumno alumno = new alumno();
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(alumno);
            lblTitle.Text = "Alumnos";
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            asistencia asistencia = new asistencia();
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(asistencia);
            lblTitle.Text = "Asistencia";
        }
    }
}
