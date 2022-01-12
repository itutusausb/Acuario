using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloNegocio;

namespace Presentacion
{
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
           // btn_login.BackColor = Color.FromArgb(0, 163, 254);
        }

        private void btn_login_MouseClick(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.FromArgb(64, 153, 255);
        }

        private void btn_login_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)

            
        {
            if(txtUsuario.Text !="" && txtPassword.Text != "")
            {
                String usuario = txtUsuario.Text;
                String password = txtPassword.Text;
                Boolean existe = ModeloNegocio.Usuarios.LoginUsuario(usuario, password);
                if (existe)
                {
                    Presentacion.Dashboard principal = new Presentacion.Dashboard();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("El usuario " + usuario + " no se encuentra registrado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
