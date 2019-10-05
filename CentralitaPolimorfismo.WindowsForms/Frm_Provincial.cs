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
    public partial class Frm_Provincial : Frm_Llamada
    {
        public Frm_Provincial()
        {
            InitializeComponent();
            this.cmbFranja.Items.Add(Franja.Franja_1);
            this.cmbFranja.Items.Add(Franja.Franja_2);
            this.cmbFranja.Items.Add(Franja.Franja_3);
            this.cmbFranja.SelectedIndex = 0;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.llamada = new Provincial(this.txtOrigen.Text, (Franja) this.cmbFranja.SelectedItem, float.Parse(this.txtDuracion.Text), this.txtDestino.Text);
            base.btnAceptar_Click(sender, e);
        }
    }
}
