using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public class Local : Llamada
    {
        protected float _costo;

        #region PROPIEDADES
        public override float CostoLlamada
        {
            get => this._costo;
        }
        #endregion

        #region CONSTRUCTORES
        public Local(Llamada unaLlamada, float costo) : 
            this (unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : 
            base (origen, destino, duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region METODOS
        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();

            palabra.Append(base.Mostrar());
            palabra.AppendLine();
            palabra.Append("Llamada Local ------------------------------");
            palabra.AppendLine();
            palabra.Append(" - Costo: ");
            palabra.Append(this._costo);
            palabra.AppendLine();
            palabra.Append("--------------------------------------------");
            palabra.AppendLine();
            palabra.AppendLine();

            return palabra.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public override bool Equals(object obj)
        {
            return obj is Local;    
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
