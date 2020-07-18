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
            TotalCarnes carnes = new TotalCarnes();
            double total = 0;
            int pessoas = Convert.ToInt32(txtPessoas.Text);

            lbCBSO.Text = (CarneHomem.CBSO*pessoas).ToString("F3") + " kg";
            lbCBCO.Text = (CarneHomem.CBCO*pessoas).ToString("F3") + " kg";

            total = CarneHomem.totalHomem() * pessoas;
            lbTotal.Text = total.ToString("F3") + " kg";



        }
    }
}
