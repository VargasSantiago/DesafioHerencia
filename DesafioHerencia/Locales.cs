using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Locales : Inmobiliaria
    {
        private int numeroVentanas;

        public Locales()
        {
        }

        public int getNumeroVentanas()
        {
            return numeroVentanas;
        }

        public void setNumeroVentanas(int numeroVentanas)
        {
            this.numeroVentanas = numeroVentanas;
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
            if (this.getNumeroMetrosCuadrados() > 50)
            {
                this.porcentaje = this.porcentaje + 1;
            }

            if (this.getNumeroVentanas() <= 1)
            {
                this.porcentaje = this.porcentaje - 2;
            }
            else
            {
                if (this.getNumeroVentanas() > 4)
                {
                    this.porcentaje = this.porcentaje + 2;
                }
            }
        } 
    }
}
