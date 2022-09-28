namespace ejercicio
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbVentana = new System.Windows.Forms.WebBrowser();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbVentana
            // 
            this.wbVentana.Location = new System.Drawing.Point(0, 42);
            this.wbVentana.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVentana.Name = "wbVentana";
            this.wbVentana.Size = new System.Drawing.Size(800, 408);
            this.wbVentana.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 10);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(93, 12);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(176, 13);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(27, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(242, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(456, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(704, 13);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(24, 23);
            this.btnIr.TabIndex = 5;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(209, 13);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(27, 23);
            this.btnAdelante.TabIndex = 6;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(739, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(49, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.wbVentana);
            this.Name = "frmInicio";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbVentana;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnHome;
    }
}