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
    public partial class Frm_Centralita : Form
    {
        private Centralita nuevaCentral;
        Llamada aux;

        public Frm_Centralita()
        {
            InitializeComponent();
            nuevaCentral = new Centralita();
            this.cboOrdenamiento.Items.Add("Ordenar por Duracion");
            this.cboOrdenamiento.SelectedItem = "Ordenar por Duracion";
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Frm_Local formLocal = new Frm_Local();
            formLocal.ShowDialog();
            

            if (formLocal.DialogResult == DialogResult.OK)
            {
                aux = formLocal.Llamada;
                this.nuevaCentral += formLocal.Llamada;
                this.ActualizarListado();
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            Frm_Provincial formProvincial = new Frm_Provincial();
            formProvincial.ShowDialog();

            if(formProvincial.DialogResult == DialogResult.OK)
            {
                aux = formProvincial.Llamada;
                this.nuevaCentral += formProvincial.Llamada;
                this.ActualizarListado();
            }
        }

        private void ActualizarListado()
        {
            this.lstVisor.Items.Clear();
            foreach(Llamada item in this.nuevaCentral.Llamadas)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }

        private void ImprimirListaOrdenada()
        {
            switch(this.cboOrdenamiento.SelectedItem)
            {
                case "Ordenar por Duracion Ascendente":
                    this.nuevaCentral.OrdenarLlamadas();
                    this.ActualizarListado();
                    break;
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
