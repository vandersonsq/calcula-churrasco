using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Churrasco
{
    public partial class frmCalculador : Form
    {
        public frmCalculador()
        {
            InitializeComponent();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            CarnesHomens CarneHomem = new CarnesHomens();
            CarnesCriancas CarneCrianca = new CarnesCriancas();
            CarnesMulheres CarneMulher = new CarnesMulheres();

            double total = 0;
            int numeroHomens = Convert.ToInt32(txtHomens.Text);
            int numeroCrianças = Convert.ToInt32(txtHomens.Text);
            int numeroMulheres = Convert.ToInt32(txtHomens.Text);
            double cbsoFinal = (CarneCrianca.CBSO * numeroCrianças) + (CarneHomem.CBSO * numeroHomens) + (CarneMulher.CBSO * numeroMulheres);

            lbCBSO.Text = Convert.ToString(cbsoFinal) + " kg";

            lbCBCO.Text = (CarneHomem.CBCO* numeroHomens).ToString("F3") + " kg";

            lbCBSO.Text = (CarneMulher.CBSO * numeroMulheres).ToString("F3") + " kg";
            lbCBCO.Text = (CarneMulher.CBCO * numeroMulheres).ToString("F3") + " kg";

            

            //total = CarneHomem.totalHomem() * pessoas;
            lbTotal.Text = total.ToString("F3") + " kg";



        }
    }
}
