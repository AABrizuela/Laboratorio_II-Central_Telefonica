using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    class Provincial : Llamada
    {
        Franja _franjaHoraria;

        #region PROPIEDADES
        public override float CostoLlamada
        {
            get => this.CalcularCosto();
        }
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja miFranja, Llamada unaLlamada) : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {
             
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : 
            base(origen, destino, duracion)
        {

        }
        #endregion
        
        #region METODOS
        private float CalcularCosto()
        {
            switch (_franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = this.Duracion * 0.66f;
                    break;
                default:
                    break;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder
        }
        #endregion
    }
}
