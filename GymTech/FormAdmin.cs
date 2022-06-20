using GymTech;

namespace Administrador
{

    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        static List<Persona> personaList = new List<Persona>();
        public List<Persona> GetPersonaList() { return personaList; } 
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == ""|| txtNombre.Text == "" || txtEdad.Text == "" || txtAdress.Text == "" || cboPlan.Text == "" || cboTrainer.Text == "")
            {
                MessageBox.Show("Los campos (*) son obligatorios.", "Error al Registrar");
            }
            else
            {
                bool dniEncontrado = false;
                foreach (var persona in personaList)
                { //  Para Verificar si el DNI ya esta registrado
                    if (persona.Dni == txtDni.Text) { MessageBox.Show("Este DNI ya se encuentra registrado", "Alerta"); dniEncontrado = true; }
                }
                if (dniEncontrado != true)
                {
                    personaList.Add(new Persona { Dni = txtDni.Text, Name = txtNombre.Text, Edad = txtEdad.Text, Adress = txtAdress.Text, Genero = cboGen.Text, Plan = cboPlan.Text, Trainer = cboTrainer.Text });
                    mostrar();
                }
            }
        }
        public void mostrar()
        {
            txtLista.Clear();
            foreach(var p in personaList)
            {
                txtLista.Text += p.Dni + "  -  " + p.Name + "  -  " + p.Edad + "  -  " + p.Adress + "  -  " + p.Genero + "  -  " + p.Plan + "  -  " + p.Trainer + "\r\n";
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + personaList.Count + " clientes");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                string tipo = "";
                bool flag = false;

                for (int i = 0; i < personaList.Count; i++)
                {
                    if (personaList[i].Dni == txtMiembro.Text)
                    {
                        flag = true;
                        tipo = personaList[i].Plan;
                        MessageBox.Show("Su tipo de suscripción es " + tipo);
                        if (tipo == "Mensual (S/. 87.00)") { MessageBox.Show("Incluye evaluación de composición corporal y programa de entrenamiento personalizado. " + " Su suscripción acaba en 20/07/2022"); }
                        if (tipo == "Trimestral (S/. 462.00)") { MessageBox.Show("Incluye un descuento del 25% si desea incluir otro mes a su plan de membresía. " + " Su suscripción acaba en 20/09/2022"); }
                        if (tipo == "Anual (S/. 1169.00)") { MessageBox.Show("Descuento del 15% si desea contratar un plan igual a este acabada la membresía. " + "Su inscripción acaba en 20/06/2023"); }
                    }
                }
            if (flag == false)
            {
                MessageBox.Show("No se encontro al miembro", "Alerta");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}