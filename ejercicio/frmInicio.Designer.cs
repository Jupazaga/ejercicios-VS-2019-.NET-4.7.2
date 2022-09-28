
namespace ejercicio
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.axWmpVentana = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(13, 305);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(133, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar Archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // axWmpVentana
            // 
            this.axWmpVentana.Enabled = true;
            this.axWmpVentana.Location = new System.Drawing.Point(13, 13);
            this.axWmpVentana.Name = "axWmpVentana";
            this.axWmpVentana.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmpVentana.OcxState")));
            this.axWmpVentana.Size = new System.Drawing.Size(549, 274);
            this.axWmpVentana.TabIndex = 0;
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(152, 305);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(133, 23);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir ";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Location = new System.Drawing.Point(291, 305);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(133, 23);
            this.btnPausa.TabIndex = 3;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(429, 305);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(133, 23);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 340);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.axWmpVentana);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.axWmpVentana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWmpVentana;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnDetener;
    }
}

