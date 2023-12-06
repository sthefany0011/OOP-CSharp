using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadaAObjetos4
{
     class Retangulo
    {
        public double Largura;
        public double Altura;




        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0*(Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura*Largura)+(Altura*Altura));
        }


        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }



}
