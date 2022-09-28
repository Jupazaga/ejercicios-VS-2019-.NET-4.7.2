using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;
using System.Windows.Forms;


namespace ejercicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = " Archivos mp4|*.mp4| Archivos mp3 |*.mp3| Archivos AVI |*.avi| Archivos MPEG |*.mpeg| Archivos WMP |*.wmp| Archivos FLV |*.FLV"
            };
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    axWmpVentana.URL = fileDialog.FileName;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            
            
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWmpVentana.Ctlcontrols.play();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axWmpVentana.Ctlcontrols.pause();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            axWmpVentana.Ctlcontrols.stop();
        }
    }
}
