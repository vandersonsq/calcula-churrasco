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

                cbsoFinal = (CarneCrianca.CBSO * numeroCrianças) + (CarneHomem.CBSO * numeroHomens) + (CarneMulher.CBSO * numeroMulheres);
                cbcoFinal = (CarneCrianca.CBCO * numeroCrianças) + (CarneHomem.CBCO * numeroHomens) + (CarneMulher.CBCO * numeroMulheres);
                carneSuinaFinal = (CarneCrianca.carneSuina * numeroCrianças) + (CarneHomem.carneSuina * numeroHomens) + (CarneMulher.carneSuina * numeroMulheres);
                frangoFinal = (CarneCrianca.frango * numeroCrianças) + (CarneHomem.frango * numeroHomens) + (CarneMulher.frango * numeroMulheres);
                coracaodeFrangoFinal = (CarneCrianca.coracaodeFrango * numeroCrianças) + (CarneHomem.coracaodeFrango * numeroHomens) + (CarneMulher.coracaodeFrango * numeroMulheres);
                linguicaFinal = (CarneCrianca.linguica * numeroCrianças) + (CarneHomem.linguica * numeroHomens) + (CarneMulher.linguica * numeroMulheres);
                paodeAlhoFinal = (CarneCrianca.paodeAlho * numeroCrianças) + (CarneHomem.paodeAlho * numeroHomens) + (CarneMulher.paodeAlho * numeroMulheres);

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
