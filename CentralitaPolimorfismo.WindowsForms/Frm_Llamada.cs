using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo.Entidades;

namespace Centralita_WF
{
    public partial class Frm_Llamada : Form
    {
        protected Llamada llamada;

        public Llamada Llamada { get { return this.llamada; } }

        //public Llamada miLlamada
        //{
        //    get { return this.llamada; }
        //}

        public Frm_Llamada()
        {
            InitializeComponent();
        }

        public Frm_Llamada(ETipoLlamada tipo)
        {
            InitializeComponent();

        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;            
        }        

        private void Frm_Llamada_Load(object sender, EventArgs e)
        {

        }
    }
}
