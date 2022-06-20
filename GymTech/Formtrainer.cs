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
    public partial class Formtrainer : Form
    {
        List<Persona> personaList = new List<Persona>();
        Queue<Trainer> rutina = new Queue<Trainer>();
        Trainer train = new Trainer();
        List<string> maquinas = new List<string> { "" };
        public Formtrainer(List<Persona> listpersona)
        {
            InitializeComponent();
            personaList = listpersona;
        }

        int cp = 4, ce = 4, cb = 4, ct = 4, ch = 4, cpi = 4;

        private void btnselectra_Click(object sender, EventArgs e)
        { // validamos que haya seleccionado un trainer
            if (cboTrainerselec.Text == "")
            {
                MessageBox.Show("Seleccione un Trainer", "Alerta");
            }
            else
            { // mostrar los alumnos del trainer
                txtalumselec.Clear();
                train.veralumnostrainer(personaList, cboTrainerselec, txtalumselec);
                if (txtalumselec.Text == "")
                {
                    MessageBox.Show("El Trainer no tiene alumnos asignados", "Mensaje");
                }
            }

        }
        public void asignarrutina()
        {
            bool flag = false;
            txtalumselec.Clear();
            if (cp > 0 || ce > 0 || cb > 0 || ct > 0 || ch > 0 || cpi > 0)
            {
                for (int i = 0; i < personaList.Count; i++)
                {
                    if (personaList[i].Dni == txtDNI.Text)
                    {
                        flag = true;
                        if (cbomaquina.Text == "" || cboasignarrutina.Text == "")
                        {
                            MessageBox.Show("Seleccione una rutina y Máquina");
                        }
                        else
                        {
                            personaList[i].rutina = cboasignarrutina.Text;
                            personaList[i].maquina = cbomaquina.Text;
                            // validamos que existan máquinas disponibles para asignarle a los miembros
                            if (personaList[i].maquina == "Pecho") { if (cp != 0) cp--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }
                            if (personaList[i].maquina == "Espalda") { if (ce != 0) ce--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }
                            if (personaList[i].maquina == "Biceps") { if (cb != 0) cb--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }
                            if (personaList[i].maquina == "Triceps") { if (ct != 0) ct--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }
                            if (personaList[i].maquina == "Hombro") { if (ch != 0) ch--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }
                            if (personaList[i].maquina == "Pierna") { if (cpi != 0) cpi--; else { MessageBox.Show($"Todas las máquinas de {cbomaquina.Text} estan ocupadas"); } }

                            if (flag == false)
                            {
                                MessageBox.Show("El DNI ingresado no se encuentra registrado", "Alerta");
                            }

                            listademaquinas();
                            train.veralumnostrainer(personaList, cboTrainerselec, txtalumselec);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay máquinas disponibles", "Alerta");
            }
        }

        private void btnasigrutin_Click(object sender, EventArgs e)
        {
            asignarrutina();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cborutina1.Text == "" && cborutina2.Text == "")
            {
                MessageBox.Show("No se puede registrar un rutina vacia ");
            }
            else
            {
                rutina.Enqueue(new Trainer { rutina1 = cborutina1.Text, rutina2 = cborutina2.Text });
                cboasignarrutina.Items.Clear();
                foreach (var p in rutina)
                {
                    cboasignarrutina.Items.Add(p.rutina1 + " + " + p.rutina2);
                }

                txtDNI.Focus();
            }

        }
        public void listademaquinas()
        {
            lstmaquinas.Items.Clear();
            lstmaquinas.Items.Add("Máquina para pecho:" + cp + "\r\n");
            lstmaquinas.Items.Add("Máquina para espalda:" + ce + "\r\n");
            lstmaquinas.Items.Add("Máquina para biceps:" + cb + "\r\n");
            lstmaquinas.Items.Add("Máquina para triceps:" + ct + "\r\n");
            lstmaquinas.Items.Add("Máquina para hombro:" + ch + "\r\n");
            lstmaquinas.Items.Add("Máquina para pierna:" + cpi + "\r\n");
        }
        private void Formtrainer_Load(object sender, EventArgs e)
        {
            listademaquinas();
        }
    }
}
