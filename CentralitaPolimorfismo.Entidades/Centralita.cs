using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo.Entidades
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas = new List<Llamada>();
        protected string _razonSocial;        

        #region PROPIEDADES
        public float GananciaPorLocal
        {
            get => this.CalcularGanancia(TipoLLamada.Local);
        }

        public List<Llamada> Llamadas
        {
            get => this._listaDeLlamadas;
        }

        public float GananciaPorProvincia
        {
            get => this.CalcularGanancia(TipoLLamada.Provincial);
        }

        public float GananciaTotal
        {
            get => this.CalcularGanancia(TipoLLamada.Todas);
        }
        #endregion

        #region CONSTRUCTORES
        public Centralita() : this("")
        {

        }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region METODOS
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(!Object.Equals(nuevaLlamada, null))
            {
                this._listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        private float CalcularGanancia(TipoLLamada tipo)
        {
            float retorno = 0;
            Local localAux = null;
            Provincial provAux = null;

            switch (tipo)
            {
                case TipoLLamada.Local:
                    foreach(Llamada item in _listaDeLlamadas)
                    {
                        if(localAux.Equals(item))
                        {
                            retorno = retorno + item.CostoLlamada;
                        }
                    }
                    break;
                case TipoLLamada.Provincial:
                    foreach(Llamada item in _listaDeLlamadas)
                    {
                        if(provAux.Equals(item))
                        {
                            retorno = retorno + item.CostoLlamada;
                        }
                    }
                    break;
                case TipoLLamada.Todas:
                    foreach(Llamada item in _listaDeLlamadas)
                    {
                        retorno = retorno + item.CostoLlamada;
                    }
                    break;                
            }
            return retorno;
        }
        #endregion

        #region SOBRECARGAS
        //public override string ToString()
        //{
        //    foreach(Llamada item in _listaDeLlamadas)
        //    {
                
        //    }
        //    return retorno;
        //}

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            if(!Object.Equals(central, null) && !Object.Equals(nuevaLlamada, null))
            {
                foreach(Llamada aux in central.Llamadas)
                {
                    if(aux == nuevaLlamada)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if(central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            return central;
        }
        #endregion
    }
}
