using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia
{
    public partial class Form1 : Form
    {
        Pisos p1 = new Pisos();
        Locales l1 = new Locales();

        Boolean opcionPisos = false;
        Boolean opcionLocales = false;

        public Form1()
        {
            

            InitializeComponent();

            textBox3.BackColor = Color.Tan;
            textBox4.BackColor = Color.Tan;
            label6.Text = "";
            label7.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "Piso en el que se encuentra:";
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.Fixed3D;

            opcionPisos = true;
            opcionLocales = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            label7.Text = "N° Ventanas: ";
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.Fixed3D;

            opcionPisos = false;
            opcionLocales = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Años del inmueble:";
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.Fixed3D;
            textBox3.Text = "0";

            l1.setAntiguedad (Convert.ToInt32(textBox3.Text));
            p1.setAntiguedad(l1.getAntiguedad());            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "Años del inmueble:";
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button5_Click(object sender, EventArgs e)
        {   

            if (opcionLocales == true)
            {
                l1.setAntiguedad(Convert.ToInt32(textBox3.Text));
                l1.calculosGenerales();

                l1.setNumeroMetrosCuadrados(Convert.ToInt32(textBox2.Text));
                l1.setNumeroVentanas(Convert.ToInt32(textBox4.Text));
                l1.calculoPorcentajes();
                label8.Text = "Porcentaje: " + l1.getPorcentaje() + "%";
            }
            else
            {
                if (opcionPisos == true)
                {
                    p1.setAntiguedad(Convert.ToInt32(textBox3.Text));
                    p1.calculosGenerales();

                    p1.setPiso(Convert.ToInt32(textBox4.Text));
                    p1.calculoPorcentajes();
                    label8.Text = "Porcentaje: " + p1.getPorcentaje() + "%";
                }
            }           
        }
    }
}
