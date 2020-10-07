using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    abstract class Inmobiliaria
    {
        protected String direccion;
        protected int numeroMetrosCuadrados;
        protected int antiguedad;
        protected int porcentaje;

        public Inmobiliaria(String direccion, int numeroMetrosCuadrados, int antiguedad, int porcentaje)
        {
            this.direccion = direccion;
            this.numeroMetrosCuadrados = numeroMetrosCuadrados;
            this.antiguedad = antiguedad;
            this.porcentaje = porcentaje;
        }

        public Inmobiliaria()
        {
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

        public abstract void calculoPorcentajes();

        public void calculosGenerales()
        {
            if (this.antiguedad == 0)
            {
                this.porcentaje = 0;
            }
            else
            {
                if ((this.antiguedad > 0) && (this.antiguedad < 15))
                {
                    this.porcentaje = -1;
                }
                else
                {
                    if (this.antiguedad >= 15)
                    {
                        this.porcentaje = -2;
                    }
                }
            }
        }
    }
}

public class Class1 {

	public Class1(){

	}

	~Class1(){

	}

	public virtual void Dispose(){

	}

}//end Class1
