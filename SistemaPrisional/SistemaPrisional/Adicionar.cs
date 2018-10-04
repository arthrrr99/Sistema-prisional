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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();

            txt_nome.Enabled = false;
            txt_endereco.Enabled = false;
            txt_rg.Enabled = false;
            txt_cpf.Enabled = false;
            txt_bairro.Enabled = false;
            txt_estado.Enabled = false;
            txt_sigla.Enabled = false;
            txt_mae.Enabled = false;
            txt_pai.Enabled = false;
            txt_crimes.Enabled = false;
            pict_foto.Enabled = false;
        }

        
    }
}
