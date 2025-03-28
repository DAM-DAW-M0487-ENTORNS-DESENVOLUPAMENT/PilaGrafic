using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaGraficWF
{
    internal static class Compilador
    {
        public bool Validar(string expressio)
        {

        }

        private string RutaArxiu()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }
    }
}