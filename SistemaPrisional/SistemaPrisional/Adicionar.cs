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

            txt_nome.Enabled = true;
            txt_endereco.Enabled = true;
            txt_rg.Enabled = true;
            txt_cpf.Enabled = true;
            txt_bairro.Enabled = true;
            txt_estado.Enabled = true;
            txt_sigla.Enabled = true;
            txt_mae.Enabled = true;
            txt_pai.Enabled = true;
            txt_crimes.Enabled = true;
            pict_foto.Enabled = true;
            txt_nascimento.Enabled = true;
            
        }

      
    }
}
