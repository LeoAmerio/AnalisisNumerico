using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace AnalisisNumericoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Biseccion(object sender, EventArgs e)
        {

            double fx, area;


            // if (AnalizadorDeFunciones.Sintaxis("2*x+2", 'x')) //pasamos la funcion con la variable a evaluar
            // {
            //     fx = AnalizadorDeFunciones.EvaluaFx(2.3); 
            //     area= AnalizadorDeFunciones.Integra(2,5,0.0003);
            //      
            //     Console.WriteLine("f(2.3)={0} Area={1}", fx,area);
            //
            // }
            // else{
            //     // aquí mensaje de error en sintaxis
            // }
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void toleranceValue_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void iterationValue_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void biseccionBtn_Click(object sender, EventArgs e)
        {
            if (functionInput.Text != "" && xiValue.Text != "" && xdValue.Text != "" && toleranceValue.Text != "" &&
                iterationValue.Text != "")
            {
                warningLabel.Text = "";
                Calculo AnalizadorDeFunciones = new Calculo();
                string fx = functionInput.Text;
                AnalizadorDeFunciones.Sintaxis(fx, 'x');
                double xi = double.Parse(xiValue.Text);
                double xd = double.Parse(xiValue.Text);
                double fXi = AnalizadorDeFunciones.EvaluaFx(xi);
                double fXd = AnalizadorDeFunciones.EvaluaFx(xd);
                while (fXi * fXd > 0)
                {
                    
                }
            }
        }
        
        
    }
}
