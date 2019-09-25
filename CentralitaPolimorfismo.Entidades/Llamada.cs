using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        #region CONSTRUCTOR
        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        #endregion
        
        #region PROPIEDADES
        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get => this._duracion;
        }

        public string NroDestino
        {
            get => this._nroDestino;
        }

        public string NroOrigen
        {
            get => this._nroOrigen;
        }
        #endregion

        #region METODOS
        protected virtual string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();
            palabra.Append("Origen: ");
            palabra.Append(this._nroOrigen);
            palabra.Append(" - Destino: ");
            palabra.Append(this._nroDestino);
            palabra.Append(" - Duracion: ");
            palabra.Append(this._duracion);
            return palabra.ToString();
        }

        public int OrdenarPorDuracion()
        {
            return 0;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if(!Object.Equals(uno, null) && !Object.Equals(dos, null))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        #endregion

    }
}
