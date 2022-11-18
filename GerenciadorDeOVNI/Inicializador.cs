using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
            // Popular o combobox com o array da classe:
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Obter os valores da interface:
            string planetaOrigem = cmbPlanetas.Text;
            int maxTripulantes = (int)txbTripulantes.Value;
            int maxAbduzidos = (int)txbAbduzidos.Value;

            // Criar obj do tipo OVNI:
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes,
                maxAbduzidos, planetaOrigem);

            // Mudar de janela:
            Gerenciador gerenciador = new Gerenciador(ovni);
            gerenciador.ShowDialog();
        }

        private void txbTripulantes_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
