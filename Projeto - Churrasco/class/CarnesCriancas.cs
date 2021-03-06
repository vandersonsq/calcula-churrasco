﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___Churrasco
{
    class CarnesCriancas
    {
        private double CBSO = 0.085;
        private double CBCO = 0.099;
        private double carneSuina = 0.043;
        private double frango = 0.052;
        private double coracaodeFrango = 0.036;
        private double linguica = 0.048;
        private double paodeAlho = 0.025;

        public CarnesCriancas()
        {

        }
        public CarnesCriancas(double cBSO, double cBCO, double carneSuina, double frango, double coracaodeFrango, double linguica, double paodeAlho)
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
