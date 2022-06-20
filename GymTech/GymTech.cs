using Administrador;
namespace GymTech
{
    public partial class GymTech : Form
    {
        public GymTech()
        {
            InitializeComponent();
        }
        private Form formularioActivo = null;
        private void abrirForm(Form FormularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(FormularioHijo);
            panelHijo.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            abrirForm(new FormAdmin());
            
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            FormAdmin temp = new FormAdmin();
            abrirForm(new Formtrainer(temp.GetPersonaList()));
        }

        private void btnMiembro_Click(object sender, EventArgs e)
        {
            FormAdmin temp = new FormAdmin();
            abrirForm(new Formmiembro(temp.GetPersonaList()));
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            formularioActivo.Close();
        }
    }
}