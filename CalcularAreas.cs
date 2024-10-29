using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class CalcularAreas : IOperaciones
    {
        public double ResultadoAreaDeUnCuadrado { get; set; }
        public double ResultadoAreaDeUnRectangulo { get; set; }
        public double ResultadoAreaDeUnRombo { get; set; }
        public double ResultadoAreaDeUnTrapecio { get; set; }
        public double ResultadoAreaDeUnTriangulo { get; set; }

        public CalcularAreas()
        {
            this.ResultadoAreaDeUnCuadrado = 0;
            this.ResultadoAreaDeUnRectangulo = 0;
            this.ResultadoAreaDeUnRombo = 0;
            this.ResultadoAreaDeUnTrapecio = 0;
            this.ResultadoAreaDeUnTriangulo = 0;
        }

        public double AreaDeUnCuadrado(double l)
        {
            ResultadoAreaDeUnCuadrado= l * l;
            return ResultadoAreaDeUnCuadrado;
        }

        public double AreaDeUnRectangulo(double b, double h)
        {
            ResultadoAreaDeUnRectangulo= b * h;
            return ResultadoAreaDeUnRectangulo;
        }

        public double AreaDeUnRombo(double D, double d)
        {
            ResultadoAreaDeUnRombo= (D * d) / 2;
            return ResultadoAreaDeUnRombo;
        }

        public double AreaDeUnTrapecio(double B, double b, double h)
        {
            ResultadoAreaDeUnTrapecio= ((B + b) * h) / 2;
            return ResultadoAreaDeUnTrapecio;
        }

        public double AreaDeUnTriangulo(double b, double h)
        {
            ResultadoAreaDeUnTriangulo= (b * h) / 2;
            return ResultadoAreaDeUnTriangulo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"El área del cuadrado es: {ResultadoAreaDeUnCuadrado} cm");
            Console.WriteLine($"El área del rectángulo es: {ResultadoAreaDeUnRectangulo} cm");
            Console.WriteLine($"El área del rombo es: {ResultadoAreaDeUnRombo} cm");
            Console.WriteLine($"El área del trapecio es: {ResultadoAreaDeUnTrapecio} cm");
            Console.WriteLine($"El área del triángulo es: {ResultadoAreaDeUnTriangulo} cm");
        }

    }
}
