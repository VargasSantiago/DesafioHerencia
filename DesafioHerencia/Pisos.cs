using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Pisos : Inmobiliaria
    {
        private int piso;

        public Pisos()
        {
        }

        public int getPiso()
        {
            return piso;
        }

        public void setPiso(int piso)
        {
            this.piso = piso;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public int getNumeroMetrosCuadrados()
        {
            return numeroMetrosCuadrados;
        }

        public void setNumeroMetrosCuadrados(int numeroMetrosCuadrados)
        {
            this.numeroMetrosCuadrados = numeroMetrosCuadrados;
        }

        public int getAntiguedad()
        {
            return antiguedad;
        }

        public void setAntiguedad(int antiguedad)
        {
            this.antiguedad = antiguedad;
        }

        public int getPorcentaje()
        {
            return porcentaje;
        }

        public void setPorcentaje(int porcentaje)
        {
            this.porcentaje = porcentaje;
        }

        public override void calculoPorcentajes()
        {
            if (this.getPiso() >= 3)
            {
                this.porcentaje = this.porcentaje + 3;
            }
        }
    }
}
