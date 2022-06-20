using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTech
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        GymTech app = new GymTech();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text=="root")
            {
                this.Close();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos o usuario no registrado", "Error Login");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
