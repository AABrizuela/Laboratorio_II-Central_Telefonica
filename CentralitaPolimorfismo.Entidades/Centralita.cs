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
            get => this.CalcularGanancia(ETipoLlamada.Local);
        }

        public List<Llamada> Llamadas
        {
            get => this._listaDeLlamadas;
        }

        public float GananciaPorProvincia
        {
            get => this.CalcularGanancia(ETipoLlamada.Provincial);
        }

        public float GananciaTotal
        {
            get => this.CalcularGanancia(ETipoLlamada.Todas);
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

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float retorno = 0;
            float totalLocal = 0;
            float totalProvincial = 0;
            float totalTodas = 0;            

            foreach (Llamada item in _listaDeLlamadas)
            {
                if(item is Local)
                {
                    totalLocal += item.CostoLlamada;
                }
                else
                {
                    totalProvincial += item.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case ETipoLlamada.Local:
                    retorno = totalLocal;          
                    break;

                case ETipoLlamada.Provincial:                        
                    retorno = totalProvincial;
                    break;
                case ETipoLlamada.Todas:
                    retorno = totalLocal + totalProvincial;
                    break;                
            }
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            Llamada auxiliar = this._listaDeLlamadas.First();
            if(!Object.Equals(auxiliar, null))
            {
                this._listaDeLlamadas.Sort(auxiliar.OrdenarPorDuracion);
            }
        }
        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            string cadena = "";

            foreach(Llamada auxLlamada in _listaDeLlamadas)
            {
                cadena += auxLlamada.ToString();
            }

            return cadena;
        }

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
            
            return central;
        }
        #endregion
    }
}
