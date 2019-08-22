using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peixe
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtbTelefone novaform = new mtbTelefone();
            novaform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Peixes peixes = new Peixes();
            peixes.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
