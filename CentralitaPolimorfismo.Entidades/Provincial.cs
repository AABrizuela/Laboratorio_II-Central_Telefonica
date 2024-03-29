﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public class Provincial : Llamada
    {
        Franja _franjaHoraria;

        #region PROPIEDADES
        public override float CostoLlamada
        {
            get => this.CalcularCosto();
        }
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja miFranja, Llamada unaLlamada) : 
            this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {
             
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : 
            base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        #endregion
        
        #region METODOS
        private float CalcularCosto()
        {
            float retorno = 0;

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
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();

            palabra.Append(base.Mostrar());
            palabra.AppendLine();
            //palabra.Append("Llamada Provincial -------------------------");
            //palabra.AppendLine();
            palabra.Append(" - Franja Horaria: ");
            palabra.Append(this._franjaHoraria);
            //palabra.AppendLine();
            //palabra.Append("--------------------------------------------");
            //palabra.AppendLine();
            palabra.Append(" - Costo Llamada: ");
            palabra.Append(this.CostoLlamada);
            //palabra.AppendLine();
            //palabra.Append("--------------------------------------------");
            //palabra.AppendLine();
            //palabra.AppendLine();

            return palabra.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
