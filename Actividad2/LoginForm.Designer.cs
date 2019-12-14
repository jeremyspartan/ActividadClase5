namespace Actividad2
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.recoveryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(132, 56);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(303, 20);
            this.usuarioTextBox.TabIndex = 0;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Location = new System.Drawing.Point(132, 108);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(303, 20);
            this.contraseñaTextBox.TabIndex = 1;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(66, 56);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(46, 13);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // recoveryLinkLabel
            // 
            this.recoveryLinkLabel.AutoSize = true;
            this.recoveryLinkLabel.Location = new System.Drawing.Point(322, 145);
            this.recoveryLinkLabel.Name = "recoveryLinkLabel";
            this.recoveryLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.recoveryLinkLabel.TabIndex = 3;
            this.recoveryLinkLabel.TabStop = true;
            this.recoveryLinkLabel.Text = "¿Olvido su contrseña?";
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(48, 108);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(64, 13);
            this.contraseñaLabel.TabIndex = 4;
            this.contraseñaLabel.Text = "Contraseña:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(360, 173);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            this.CancelarButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelarButton_MouseClick);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(51, 173);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 6;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            this.aceptarButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.aceptarButton_MouseClick);
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(492, 253);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.recoveryLinkLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Bienvenido al sistema";
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.LinkLabel recoveryLinkLabel;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
    }
}

