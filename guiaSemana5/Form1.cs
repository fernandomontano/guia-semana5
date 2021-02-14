using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiaSemana5
{
    public partial class formguia5 : Form
    {
        public formguia5()
        {
            InitializeComponent();
        }

        private void formguia5_Load(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre;
                double salario, descuento, salariodescuento;

                nombre = txtnombre.Text;
                salario = Convert.ToDouble(txtsalario.Text);

                if (rbtn1.Checked == true)
                {
                    descuento = salario * 0.20;
                    salariodescuento = salario - descuento;
                    MessageBox.Show($"Bienvenido, {nombre}. " +
                        $"\nTu puesto es: {rbtn1.Text}." +
                        $"\nTu salario es de: ${salario}" +
                        $"\nSe te descuenta: ${descuento}" +
                        $"\nY tu salario luego de los descuentos es de: ${salariodescuento}");
                }
                if (rbtn2.Checked == true)
                {
                    descuento = salario * 0.15;
                    salariodescuento = salario - descuento;
                    MessageBox.Show($"Bienvenido, {nombre}. " +
                        $"\nTu puesto es: {rbtn2.Text}." +
                        $"\nTu salario es de: ${salario}" +
                        $"\nSe te descuenta: ${descuento}" +
                        $"\nY tu salario luego de los descuentos es de: ${salariodescuento}");
                }
                if (rbtn3.Checked == true)
                {
                    descuento = salario * 0.05;
                    salariodescuento = salario - descuento;
                    MessageBox.Show($"Bienvenido, {nombre}. " +
                        $"\nTu puesto es: {rbtn3.Text}." +
                        $"\nTu salario es de: ${salario}" +
                        $"\nSe te descuenta: ${descuento}" +
                        $"\nY tu salario luego de los descuentos es de: ${salariodescuento}");
                }
                if (rbtn1.Checked == false && rbtn2.Checked == false && rbtn3.Checked == false)
                {
                    MessageBox.Show("Debes marcar una casilla");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No se aceptan cambios vacíos.");
            }
        }
    }
}
