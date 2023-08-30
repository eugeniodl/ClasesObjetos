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
    }
}
