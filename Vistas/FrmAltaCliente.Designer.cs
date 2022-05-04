namespace Vistas
{
    partial class FrmAltaCliente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblOSCUIT = new System.Windows.Forms.Label();
            this.lblNroCarnet = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtOSCUIT = new System.Windows.Forms.TextBox();
            this.txtNroCarnet = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblValidDni = new System.Windows.Forms.Label();
            this.lblValidApellido = new System.Windows.Forms.Label();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.lblValidDireccion = new System.Windows.Forms.Label();
            this.lblValidCUIT = new System.Windows.Forms.Label();
            this.lblValidNroCarnet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese los datos del nuevo cliente";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(74, 50);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(47, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 140);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(38, 189);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblOSCUIT
            // 
            this.lblOSCUIT.AutoSize = true;
            this.lblOSCUIT.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSCUIT.Location = new System.Drawing.Point(41, 245);
            this.lblOSCUIT.Name = "lblOSCUIT";
            this.lblOSCUIT.Size = new System.Drawing.Size(62, 15);
            this.lblOSCUIT.TabIndex = 5;
            this.lblOSCUIT.Text = "CUIT OS:";
            // 
            // lblNroCarnet
            // 
            this.lblNroCarnet.AutoSize = true;
            this.lblNroCarnet.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCarnet.Location = new System.Drawing.Point(6, 293);
            this.lblNroCarnet.Name = "lblNroCarnet";
            this.lblNroCarnet.Size = new System.Drawing.Size(97, 15);
            this.lblNroCarnet.TabIndex = 6;
            this.lblNroCarnet.Text = "Nro. de Carnet:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(122, 43);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(228, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(228, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(122, 189);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(228, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtOSCUIT
            // 
            this.txtOSCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSCUIT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtOSCUIT.Location = new System.Drawing.Point(121, 243);
            this.txtOSCUIT.Name = "txtOSCUIT";
            this.txtOSCUIT.Size = new System.Drawing.Size(229, 20);
            this.txtOSCUIT.TabIndex = 11;
            // 
            // txtNroCarnet
            // 
            this.txtNroCarnet.Location = new System.Drawing.Point(121, 291);
            this.txtNroCarnet.Name = "txtNroCarnet";
            this.txtNroCarnet.Size = new System.Drawing.Size(229, 20);
            this.txtNroCarnet.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(77, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(242, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 36);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblValidDni
            // 
            this.lblValidDni.AutoSize = true;
            this.lblValidDni.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidDni.ForeColor = System.Drawing.Color.Red;
            this.lblValidDni.Location = new System.Drawing.Point(120, 66);
            this.lblValidDni.Name = "lblValidDni";
            this.lblValidDni.Size = new System.Drawing.Size(162, 13);
            this.lblValidDni.TabIndex = 15;
            this.lblValidDni.Text = "El DNI debe contener 8 numeros";
            this.lblValidDni.Visible = false;
            // 
            // lblValidApellido
            // 
            this.lblValidApellido.AutoSize = true;
            this.lblValidApellido.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidApellido.ForeColor = System.Drawing.Color.Red;
            this.lblValidApellido.Location = new System.Drawing.Point(120, 115);
            this.lblValidApellido.Name = "lblValidApellido";
            this.lblValidApellido.Size = new System.Drawing.Size(210, 13);
            this.lblValidApellido.TabIndex = 16;
            this.lblValidApellido.Text = "El Apellido debe contener al menos 3 letras";
            this.lblValidApellido.Visible = false;
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombre.Location = new System.Drawing.Point(120, 163);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(210, 13);
            this.lblValidNombre.TabIndex = 17;
            this.lblValidNombre.Text = "El Nombre debe contener al menos 3 letras";
            this.lblValidNombre.Visible = false;
            // 
            // lblValidDireccion
            // 
            this.lblValidDireccion.AutoSize = true;
            this.lblValidDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblValidDireccion.Location = new System.Drawing.Point(120, 212);
            this.lblValidDireccion.Name = "lblValidDireccion";
            this.lblValidDireccion.Size = new System.Drawing.Size(189, 13);
            this.lblValidDireccion.TabIndex = 18;
            this.lblValidDireccion.Text = "La dirección no puede estar en blanco";
            this.lblValidDireccion.Visible = false;
            // 
            // lblValidCUIT
            // 
            this.lblValidCUIT.AutoSize = true;
            this.lblValidCUIT.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidCUIT.ForeColor = System.Drawing.Color.Red;
            this.lblValidCUIT.Location = new System.Drawing.Point(118, 266);
            this.lblValidCUIT.Name = "lblValidCUIT";
            this.lblValidCUIT.Size = new System.Drawing.Size(187, 13);
            this.lblValidCUIT.TabIndex = 19;
            this.lblValidCUIT.Text = "El CUIT solo puede contener números";
            this.lblValidCUIT.Visible = false;
            // 
            // lblValidNroCarnet
            // 
            this.lblValidNroCarnet.AutoSize = true;
            this.lblValidNroCarnet.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidNroCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidNroCarnet.ForeColor = System.Drawing.Color.Red;
            this.lblValidNroCarnet.Location = new System.Drawing.Point(122, 314);
            this.lblValidNroCarnet.Name = "lblValidNroCarnet";
            this.lblValidNroCarnet.Size = new System.Drawing.Size(228, 13);
            this.lblValidNroCarnet.TabIndex = 20;
            this.lblValidNroCarnet.Text = "El Nro de Carnet solo puede contener números";
            this.lblValidNroCarnet.Visible = false;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 398);
            this.Controls.Add(this.lblValidNroCarnet);
            this.Controls.Add(this.lblValidCUIT);
            this.Controls.Add(this.lblValidDireccion);
            this.Controls.Add(this.lblValidNombre);
            this.Controls.Add(this.lblValidApellido);
            this.Controls.Add(this.lblValidDni);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNroCarnet);
            this.Controls.Add(this.txtOSCUIT);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblNroCarnet);
            this.Controls.Add(this.lblOSCUIT);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblOSCUIT;
        private System.Windows.Forms.Label lblNroCarnet;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtOSCUIT;
        private System.Windows.Forms.TextBox txtNroCarnet;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblValidDni;
        private System.Windows.Forms.Label lblValidApellido;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Label lblValidDireccion;
        private System.Windows.Forms.Label lblValidCUIT;
        private System.Windows.Forms.Label lblValidNroCarnet;
    }
}