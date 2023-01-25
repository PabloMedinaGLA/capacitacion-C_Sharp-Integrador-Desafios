using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);

            int resultado = n1 + n2;

            result.Text = resultado.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);

            int resultado = n1 - n2;

            result.Text = resultado.ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);

            int resultado = n1 * n2;

            result.Text = resultado.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);

            int resultado = n1 / n2;

            result.Text = resultado.ToString();
        }
    }
}
