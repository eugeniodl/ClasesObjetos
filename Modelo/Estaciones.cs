using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estaciones : IEnumerable
    {
        Estacion _verano;
        public Estacion Verano
        {
            get {
                if(_verano == null)
                {
                    _verano = new Estacion(12, 25, 5, 30);
                }
                return _verano; 
            }
        }

        Estacion _invierno;
        public Estacion Invierno
        {
            get
            {
                if(_invierno == null)
                {
                    _invierno = new Estacion(5, 31, 12, 24);
                }
                return _invierno;
            }
        }

        public class Estacion
        {
            private byte mesInicio;
            private byte mesFin;
            private byte diaInicio;
            private byte diaFin;

            public Estacion(byte mesInicio, byte diaInicio, byte mesFin, byte diaFin)
            {
                this.mesInicio = mesInicio;
                this.mesFin = mesFin;
                this.diaFin = diaFin;
                this.diaInicio = diaInicio;
            }

            public byte MesInicio { get => mesInicio; set => mesInicio = value; }
            public byte MesFin { get => mesFin; set => mesFin = value; }
            public byte DiaInicio { get => diaInicio; set => diaInicio = value; }
            public byte DiaFin { get => diaFin; set => diaFin = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerador();
        }

        private class Enumerador : IEnumerator
        {
            byte estacionActual = 0;
            Estaciones e = new Estaciones();
            public object Current => ObtenerEstacionActual(estacionActual);

            private Estacion ObtenerEstacionActual(byte estacionActual)
            {
                Estacion Resultado = null;
                switch(estacionActual)
                {
                    case 1:
                        Resultado = e.Verano;
                        break;
                    case 2:
                        Resultado = e.Invierno;
                        break;
                }
                return Resultado;
            }

            public bool MoveNext()
            {
                bool resultado;
                if(estacionActual == 2)
                    resultado = false;
                else
                {
                    estacionActual++;
                    resultado = true;
                }
                return resultado;
            }

            public void Reset()
            {
                estacionActual = 0;
            }
        }
    }
}
