using System;
using System.Media;
using System.Windows.Forms;

namespace Projeto___Churrasco
{
    public partial class frmCalculador : Form
    {
        SoundPlayer tocar = new System.Media.SoundPlayer();     
        public frmCalculador()
        {
            InitializeComponent();
            tocar.SoundLocation = "audio//musica.wav";
            tocar.Load();
            tocar.Play();
        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            CarnesHomens CarneHomem = new CarnesHomens();
            CarnesCriancas CarneCrianca = new CarnesCriancas();
            CarnesMulheres CarneMulher = new CarnesMulheres();

            double total;
            double cbsoFinal;
            double cbcoFinal;
            double carneSuinaFinal;
            double frangoFinal;
            double coracaodeFrangoFinal;
            double linguicaFinal;
            double paodeAlhoFinal;

            try
            {
                int numeroHomens = Convert.ToInt32(txtHomens.Text);
                int numeroCrianças = Convert.ToInt32(txtCrianças.Text);
                int numeroMulheres = Convert.ToInt32(txtMulheres.Text);

                cbsoFinal = (CarneCrianca.CBSO1 * numeroCrianças) + (CarneHomem.CBSO1 * numeroHomens) + (CarneMulher.CBSO1 * numeroMulheres);
                cbcoFinal = (CarneCrianca.CBCO1 * numeroCrianças) + (CarneHomem.CBCO1 * numeroHomens) + (CarneMulher.CBCO1 * numeroMulheres);
                carneSuinaFinal = (CarneCrianca.CarneSuina * numeroCrianças) + (CarneHomem.CarneSuina * numeroHomens) + (CarneMulher.CarneSuina * numeroMulheres);
                frangoFinal = (CarneCrianca.Frango * numeroCrianças) + (CarneHomem.Frango * numeroHomens) + (CarneMulher.Frango * numeroMulheres);
                coracaodeFrangoFinal = (CarneCrianca.CoracaodeFrango * numeroCrianças) + (CarneHomem.CoracaodeFrango * numeroHomens) + (CarneMulher.CoracaodeFrango * numeroMulheres);
                linguicaFinal = (CarneCrianca.Linguica * numeroCrianças) + (CarneHomem.Linguica * numeroHomens) + (CarneMulher.Linguica * numeroMulheres);
                paodeAlhoFinal = (CarneCrianca.PaodeAlho * numeroCrianças) + (CarneHomem.PaodeAlho * numeroHomens) + (CarneMulher.PaodeAlho * numeroMulheres);

                total = cbsoFinal + cbcoFinal + carneSuinaFinal + frangoFinal + coracaodeFrangoFinal + linguicaFinal + paodeAlhoFinal;

                lbCBSO.Text = Convert.ToString(cbsoFinal) + " kg";
                lbCBCO.Text = Convert.ToString(cbcoFinal) + " kg";
                carneSuina.Text = Convert.ToString(carneSuinaFinal) + " kg";
                frango.Text = Convert.ToString(frangoFinal) + " kg";
                coracaozinho.Text = Convert.ToString(coracaodeFrangoFinal) + " kg";
                linguica.Text = Convert.ToString(linguicaFinal) + " kg";
                arroz.Text = Convert.ToString(paodeAlhoFinal) + " kg";

                lbTotal.Text = Convert.ToString(total) + "Kg";
            }
            catch (Exception)
            {
                MessageBox.Show("Insira dados válidos!");
            }
        }
        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtHomens_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita somente números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void iTalk_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
