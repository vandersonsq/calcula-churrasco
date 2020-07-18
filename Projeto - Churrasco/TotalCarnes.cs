using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___Churrasco
{
    class TotalCarnes
    {
        CarnesHomens homens = new CarnesHomens();
        CarnesMulheres mulheres = new CarnesMulheres();
        CarnesCriancas criancas = new CarnesCriancas();

        public double CBSO()
        {
            return homens.CBSO + mulheres.CBSO + criancas.CBSO;
        }
        public double CBCO()
        {
            return homens.CBCO + mulheres.CBCO + criancas.CBCO;
        }


    }
}
