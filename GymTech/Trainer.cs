using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTech
{
    public class Trainer
    {

        public string rutina1 { get; set; }
        public string rutina2 { get; set; }
        public string maquina { get; set; }
        public void veralumnostrainer(List<Persona> personaList, ComboBox cbo, TextBox text)
        {
            for (int i = 0; i < personaList.Count; i++)
            {

                if (personaList[i].Trainer == cbo.Text && personaList[i].rutina == null && personaList[i].maquina == null)
                {
                    text.Text += personaList[i].Dni + "  -  " + personaList[i].Name + "  -  " + personaList[i].Edad + "  -  " + personaList[i].Plan + "  -  Sin rutina" + "  -  Sin máquina" + "\r\n";
                }
                if (personaList[i].Trainer == cbo.Text && personaList[i].rutina != null && personaList[i].maquina != null)
                {
                    text.Text += personaList[i].Dni + "  -  " + personaList[i].Name + "  -  " + personaList[i].Edad + "  -  " + personaList[i].Plan + "  -  " + personaList[i].rutina + "  -  " + personaList[i].maquina + "\r\n";
                }

            }
        }

    }
}
