using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace PostgradoApp
{
    public partial class Login : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Label logreg = new Label();
        public Login()
        {
            InitializeComponent();
            ActiveControl = userLoginTxtBox;
            userLoginTxtBox.Focus();
            this.Size = new Size(320, 536);
            pictureBox2.Enabled = false;
        }

        void Enter1(object sender, EventArgs e)
        {
            if (userLoginTxtBox.Text == "Usuario")
            {
                userLoginTxtBox.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (userLoginTxtBox.Text == string.Empty)
            {
                userLoginTxtBox.Text = "Usuario";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (passLoginTxtBox.Text == "Contraseña")
            {

                passLoginTxtBox.Text = string.Empty;
                passLoginTxtBox.PasswordChar = '*';
                pictureBox2.Enabled = true;

            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (passLoginTxtBox.Text == string.Empty)
            {
                passLoginTxtBox.Text = "Contraseña";
                passLoginTxtBox.PasswordChar = '\0';
                pictureBox2.Enabled = false;
                
            }
        }
        void Enter3(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nombres")
            {
                textBox3.Text = string.Empty;
            }
        }
        void Leave3(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = "Nombres";
            }
        }
        void Enter4(object sender, EventArgs e)
        {
            if (textBox4.Text == "Apellido paterno")
            {
                textBox4.Text = string.Empty;
            }
        }
        void Leave4(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.Text = "Apellido paterno";
            }
        }
        void Enter5(object sender, EventArgs e)
        {
            if (textBox5.Text == "Apellido materno")
            {
                textBox5.Text = string.Empty;
            }
        }
        void Leave5(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.Text = "Apellido materno";
            }
        }
        void Enter6(object sender, EventArgs e)
        {
            if (textBox6.Text == "Usuario")
            {
                textBox6.Text = string.Empty;
            }
        }
        void Leave6(object sender, EventArgs e)
        {
            if (textBox6.Text == string.Empty)
            {
                textBox6.Text = "Usuario";
            }
        }
        private void Enter7(object sender, EventArgs e)
        {
            if (textBox7.Text == "Contraseña")
            {
                textBox7.PasswordChar = '*';                
                textBox7.Text = string.Empty;
            }
        }
        private void Leave7(object sender, EventArgs e)
        {
            if (textBox7.Text == string.Empty)
            {
                textBox7.PasswordChar = '\0';
                textBox7.Text = "Contraseña";
            }
        }
        private void Register(object sender, EventArgs e)
        {
            Label lr = (Label)sender;

            logreg = lr;
            timer2.Start();
        }
        int go = 1;
        
        //logo postion
        void Logoposition()
        {
            if (panel1.Left == 0)
            {
                pictureBox1.Top += go;
                if (pictureBox1.Top > 50)
                {
                    timer1.Stop();
                }
            }
            if (panel2.Left == 0)
            {
                pictureBox1.Top -= go;
                if (pictureBox1.Top < 34)
                {
                    timer1.Stop();
                }
            }
        }
        void timer1_go(object sender, EventArgs e)
        {
            Logoposition();
        }
        void line()
        {
            if (panel1.Left == 0)
            {
                bunifuSeparator2.LineThickness = 2;
                bunifuSeparator2.LineColor = Color.FromArgb(0, 173, 239);
                bunifuSeparator1.LineThickness = 1;
                bunifuSeparator1.LineColor = Color.Silver;
            }
            if (panel2.Left == 0)
            {
                bunifuSeparator2.LineThickness = 1;
                bunifuSeparator2.LineColor = Color.Silver;
                bunifuSeparator1.LineThickness = 2;
                bunifuSeparator1.LineColor = Color.FromArgb(0, 173, 239);
            }
        }
        int move_speed = 20;
        void reg()
        {
            if (panel2.Left > 0)
            {
                timer1.Start();
                line();

                panel1.Left -= move_speed;
                panel2.Left -= move_speed;
                if (panel2.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }
        void log()
        {
            if (panel1.Left < 0)
            {
                timer1.Start();
                line();

                panel2.Left += move_speed;
                panel1.Left += move_speed;
                if (panel1.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }
        void timer2_go(object sender, EventArgs e)
        {
            if (logreg.Text == "Registrar")
            {
                reg();
            }
            else if (logreg.Text == "Iniciar sesión")
            {
                log();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_go);
            timer2.Tick += new EventHandler(timer2_go);
            timer1.Interval = 10;
            timer2.Interval = 5;
            timer1.Start();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userLoginTxtBox.Text))
            {
                MessageBox.Show("Por favor ingrese su nombre. ","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                userLoginTxtBox.Focus();
                return;
               
            }
            
            try
            {
                using(POSTGRADODBEntities db=new POSTGRADODBEntities())
                {
                    var query = from o in db.TUSUARIO
                                where o.usuario == userLoginTxtBox.Text && o.contraseña == passLoginTxtBox.Text
                                select o;
                    if (query.SingleOrDefault() != null)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Su usuario o contraseña es incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }

        private void unlock(object sender, EventArgs e)
        {
            if (passLoginTxtBox.PasswordChar == '*')
            {
                passLoginTxtBox.PasswordChar = '\0';
                this.pictureBox2.Image = Image.FromFile("C:/Users/Fredy Angel/Pictures/iconos/Padlock_51px.png");
            }
            else
            {
                passLoginTxtBox.PasswordChar = '*';
                this.pictureBox2.Image = Image.FromFile("C:/Users/Fredy Angel/Pictures/iconos/Lock_51px.png");
            }
        }

        private void userLoginTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                passLoginTxtBox.Focus();
            }
        }

        private void passLoginTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIniciarSesion_Click(sender, e);
            }
        }

    }
}
