using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUrl.Text)) return;
            if (txtUrl.Text.Equals("about:blank")) return;
            if (!txtUrl.Text.StartsWith("http://") && !txtUrl.Text.StartsWith("https://"))
            {
                txtUrl.Text = "http://" + txtUrl.Text;
            }
            try
            {
                wbVentana.Navigate(new Uri(txtUrl.Text));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            wbVentana.Refresh();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            wbVentana.Stop();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            wbVentana.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            wbVentana.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wbVentana.GoHome();
        }
    }
}
