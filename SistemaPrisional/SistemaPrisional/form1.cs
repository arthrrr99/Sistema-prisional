using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrisional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Buscar busc = new Buscar();
           busc.ShowDialog();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
