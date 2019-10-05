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
    public partial class Frm_Local : Frm_Llamada
    {
        public Frm_Local()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.llamada = new Local(this.txtOrigen.Text, float.Parse(this.txtDuracion.Text), this.txtDestino.Text, 
                float.Parse(this.txtCosto.Text));

            base.btnAceptar_Click(sender, e);
        }
    }
}
