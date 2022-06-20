using GymTech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class Formmiembro : Form
    {
        List<Persona> personaList = new List<Persona>();
        public Formmiembro(List<Persona> listapersona)
        {
            InitializeComponent();
            personaList = listapersona;
        }
        private void Formmiembro_Load(object sender, EventArgs e)
        {

        }
        public bool DniExiste(TextBox txtdni)
        {
            bool flag = false;
            foreach (var miembro in personaList)
            {
                if (miembro.Dni == txtdni.Text) flag = true;
            }
            return flag;
        }
        private void btnfechamembresia_Click(object sender, EventArgs e)
        {
            string tipo = "";
            string fecha = "";
            if (DniExiste(txtdniconsultado))
            {
                for (int i = 0; i < personaList.Count; i++)
                {
                    //if (tipo == "Mensual (S/. 87.00)") { fecha = " Su suscripción acaba en 20/07/2022"; }
                    //if (tipo == "Trimestral (S/. 462.00)") { fecha = "Su suscripción acaba en 20/09/2022"; }
                    //if (tipo == "Anual (S/. 1169.00)") { fecha = "Su inscripción acaba en 20/06/2023"; }
                    if (personaList[i].Dni == txtdniconsultado.Text)
                    {
                        tipo = personaList[i].Plan;
                        if (tipo == "Mensual (S/. 87.00)") { fecha = " Su suscripción acaba en 20/07/2022"; }
                        if (tipo == "Trimestral (S/. 462.00)") { fecha = "Su suscripción acaba en 20/09/2022"; }
                        if (tipo == "Anual (S/. 1169.00)") { fecha = "Su suscripción acaba en 20/06/2023"; }
                        txtmiembromostrar.Text = personaList[i].Dni + "  -  " + personaList[i].Name + "  -  " + personaList[i].Plan + "  -  " + fecha;
                    }
                }
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Alerta");
            }

        }

        private void btnconsultartrainer_Click(object sender, EventArgs e)
        {
            if (DniExiste(txtdniconsultado))
            {
                for (int i = 0; i < personaList.Count; i++)
                {

                    if (personaList[i].Dni == txtdniconsultado.Text)
                    {
                        txtmiembromostrar.Text = personaList[i].Dni + "  -  " + personaList[i].Name + "  -  " + personaList[i].Trainer;

                    }

                }
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Alerta");
            }

        }

        private void btnconsultarrutina_Click(object sender, EventArgs e)
        {
            if (DniExiste(txtdniconsultado))
            {
                for (int i = 0; i < personaList.Count; i++)
                {

                    if (personaList[i].Dni == txtdniconsultado.Text)
                    {
                        txtmiembromostrar.Text = personaList[i].Dni + "  -  " + personaList[i].Name + "  -  " + personaList[i].rutina + "  -  " + personaList[i].maquina;

                    }

                }
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Alerta");
            }

        }


    }
}
