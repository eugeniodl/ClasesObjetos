using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estaciones
    {
        Estacion _verano;

        public Estacion Verano
        {
            get
            { 
                if( _verano == null )
                {
                    _verano = new Estacion(1, 1, 15, 5);
                }
                return _verano; 
            }
        }
        Estacion _invierno;
        public Estacion Invierno
        {
            get
            { 
                if( _invierno == null )
                    _invierno = new Estacion(16, 5, 31, 12);
                return _invierno; 
            }
        }

        public class Estacion
        {
            private byte diaInicio;
            private byte mesInicio;
            private byte diaFin;
            private byte mesFin;

            public Estacion(byte diaInicio, byte mesInicio,
                byte diaFin, byte mesFin)
            {
                this.diaInicio = diaInicio;
                this.mesInicio = mesInicio;
                this.diaFin = diaFin;
                this.mesFin = mesFin;
            }

            public byte DiaInicio { get => diaInicio; set => diaInicio = value; }
            public byte MesInicio { get => mesInicio; set => mesInicio = value; }
            public byte DiaFin { get => diaFin; set => diaFin = value; }
            public byte MesFin { get => mesFin; set => mesFin = value; }
        }
    }
}
