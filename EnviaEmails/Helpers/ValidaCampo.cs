using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviaEmails.Helpers
{
    public class ValidaCampo
    {
        public static void Validar(TextBox textbox, string nome)
        {
            if (textbox.Text == string.Empty)
            {
                textbox.Focus();
                MessageBox.Show($"Preencha o campo {nome} para continuar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
    }
}
