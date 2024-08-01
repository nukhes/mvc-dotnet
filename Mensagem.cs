using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    internal class Mensagem
    {
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMessage(string message)
        {
            MessageBox.Show(message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void SuccessMessage(string message)
        {
            MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
