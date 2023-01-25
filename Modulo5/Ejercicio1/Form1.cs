using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = Convert.ToDateTime(fechadte.Text);
            string estadoCivil = estadoCbo.Text;
            string sexo = "";

            bool esExtranjero = extranChbox.Checked;


            foreach (Control control in this.sexoGroup.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        sexo = radio.Text;
                    }
                }
            }



            if (nombre == string.Empty || estadoCivil == string.Empty || sexo == string.Empty)
            {
                mensajelbl.ForeColor = Color.Red;
                mensajelbl.Text = "Por favor se deben completar todos los campos para agregar al alumno";
            }
            else
            {
                mensajelbl.ForeColor = Color.Black;
                mensajelbl.Text = "Carga Exitosamente";
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = nombre;
                row.Cells[1].Value = fecha.ToString();
                row.Cells[2].Value = estadoCivil;
                row.Cells[3].Value = sexo;
                row.Cells[4].Value = (esExtranjero == true ? "Si" : "No");
                dataGridView1.Rows.Add(row);
            }
        }
    
    }
}
