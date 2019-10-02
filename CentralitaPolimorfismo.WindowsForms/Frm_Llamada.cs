using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaTelefonica;

namespace Centralita_WF
{
    public partial class Frm_Llamada : Form
    {
        private Llamada llamada;
        public Frm_Llamada(ETipoLlamada tipo)
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string origen = this.txtOrigen.Text;
            string destino = this.txtDestino.Text;
            float duracion = float.Parse( this.txtDuracion.Text);

  
        }

        public Llamada  Llamada{ get { return this.llamada; } }

        private void Frm_Llamada_Load(object sender, EventArgs e)
        {

        }
    }
}
