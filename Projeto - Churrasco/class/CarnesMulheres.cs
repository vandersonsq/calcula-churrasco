using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___Churrasco
{
    class CarnesMulheres
    {
        private double CBSO = 0.155;
        private double CBCO = 0.125;
        private double carneSuina = 0.060;
        private double frango = 0.040;
        private double coracaodeFrango = 0.030;
        private double linguica = 0.070;
        private double paodeAlho = 0.040;

        public CarnesMulheres()
        {

        }
        public CarnesMulheres(double cBSO, double cBCO, double carneSuina, double frango, double coracaodeFrango, double linguica, double paodeAlho)
        {
            CBSO1 = cBSO;
            CBCO1 = cBCO;
            this.CarneSuina = carneSuina;
            this.Frango = frango;
            this.CoracaodeFrango = coracaodeFrango;
            this.Linguica = linguica;
            this.PaodeAlho = paodeAlho;
        }
        public double CBSO1 { get => CBSO; set => CBSO = value; }
        public double CBCO1 { get => CBCO; set => CBCO = value; }
        public double CarneSuina { get => carneSuina; set => carneSuina = value; }
        public double Frango { get => frango; set => frango = value; }
        public double CoracaodeFrango { get => coracaodeFrango; set => coracaodeFrango = value; }
        public double Linguica { get => linguica; set => linguica = value; }
        public double PaodeAlho { get => paodeAlho; set => paodeAlho = value; }
    }
}
