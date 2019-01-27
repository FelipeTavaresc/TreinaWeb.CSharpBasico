using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEstruturasRepeticao
{
    public partial class frmEstruturasRepeticao : Form
    {
        public frmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);
            //for
            /*for (int i = 0; i <= 10; i++)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
            }
            */

            //while
            int i = 1;
            while (i <= 10)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
                i++;
            }
        }
    }
}
