using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEnClaseAgregarObjetos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo", "Saludo", MessageBoxButtons.YesNo);
            MessageBox.Show("Adios mundo", "Saludo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
    }
}
