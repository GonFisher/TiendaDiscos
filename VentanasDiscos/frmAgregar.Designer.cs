namespace VentanasDiscos
{
    partial class frmAgregar
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblFecha = new Label();
            dtpLanzamiento = new DateTimePicker();
            lblCantidaCan = new Label();
            txtImgen = new TextBox();
            nudCanciones = new NumericUpDown();
            lblImagen = new Label();
            lblEstilo = new Label();
            cbxEstilo = new ComboBox();
            cbxImpresion = new ComboBox();
            lblImpresion = new Label();
            pbxAgregar = new PictureBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnImagenesLocales = new Button();
            ldldescripcionIma = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCanciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(32, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(114, 44);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(116, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(34, 97);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Lanzamiento";
            // 
            // dtpLanzamiento
            // 
            dtpLanzamiento.Format = DateTimePickerFormat.Short;
            dtpLanzamiento.Location = new Point(114, 97);
            dtpLanzamiento.Name = "dtpLanzamiento";
            dtpLanzamiento.Size = new Size(116, 23);
            dtpLanzamiento.TabIndex = 3;
            // 
            // lblCantidaCan
            // 
            lblCantidaCan.AutoSize = true;
            lblCantidaCan.Location = new Point(34, 146);
            lblCantidaCan.Name = "lblCantidaCan";
            lblCantidaCan.Size = new Size(129, 15);
            lblCantidaCan.TabIndex = 4;
            lblCantidaCan.Text = "Cantidad de Canciones";
            // 
            // txtImgen
            // 
            txtImgen.Location = new Point(323, 242);
            txtImgen.Name = "txtImgen";
            txtImgen.Size = new Size(121, 23);
            txtImgen.TabIndex = 5;
            txtImgen.MouseLeave += txtImgen_MouseLeave;
            // 
            // nudCanciones
            // 
            nudCanciones.Location = new Point(169, 144);
            nudCanciones.Name = "nudCanciones";
            nudCanciones.ReadOnly = true;
            nudCanciones.Size = new Size(61, 23);
            nudCanciones.TabIndex = 6;
            nudCanciones.TextAlign = HorizontalAlignment.Right;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(351, 224);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(62, 15);
            lblImagen.TabIndex = 7;
            lblImagen.Text = "UrlImagen";
            // 
            // lblEstilo
            // 
            lblEstilo.AutoSize = true;
            lblEstilo.Location = new Point(34, 194);
            lblEstilo.Name = "lblEstilo";
            lblEstilo.Size = new Size(35, 15);
            lblEstilo.TabIndex = 8;
            lblEstilo.Text = "Estilo";
            // 
            // cbxEstilo
            // 
            cbxEstilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstilo.FormattingEnabled = true;
            cbxEstilo.Location = new Point(114, 194);
            cbxEstilo.Name = "cbxEstilo";
            cbxEstilo.Size = new Size(121, 23);
            cbxEstilo.TabIndex = 9;
            // 
            // cbxImpresion
            // 
            cbxImpresion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxImpresion.FormattingEnabled = true;
            cbxImpresion.Location = new Point(114, 242);
            cbxImpresion.Name = "cbxImpresion";
            cbxImpresion.Size = new Size(121, 23);
            cbxImpresion.TabIndex = 10;
            // 
            // lblImpresion
            // 
            lblImpresion.AutoSize = true;
            lblImpresion.Location = new Point(32, 241);
            lblImpresion.Name = "lblImpresion";
            lblImpresion.Size = new Size(60, 15);
            lblImpresion.TabIndex = 11;
            lblImpresion.Text = "Impresion";
            // 
            // pbxAgregar
            // 
            pbxAgregar.Location = new Point(263, 67);
            pbxAgregar.Name = "pbxAgregar";
            pbxAgregar.Size = new Size(214, 154);
            pbxAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAgregar.TabIndex = 12;
            pbxAgregar.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(155, 383);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(299, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnImagenesLocales
            // 
            btnImagenesLocales.Location = new Point(328, 271);
            btnImagenesLocales.Name = "btnImagenesLocales";
            btnImagenesLocales.Size = new Size(116, 23);
            btnImagenesLocales.TabIndex = 15;
            btnImagenesLocales.Text = "Imagenes Locales";
            btnImagenesLocales.UseVisualStyleBackColor = true;
            btnImagenesLocales.Click += btnImagenesLocales_Click;
            // 
            // ldldescripcionIma
            // 
            ldldescripcionIma.AutoSize = true;
            ldldescripcionIma.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ldldescripcionIma.Location = new Point(299, 43);
            ldldescripcionIma.Name = "ldldescripcionIma";
            ldldescripcionIma.Size = new Size(135, 15);
            ldldescripcionIma.TabIndex = 16;
            ldldescripcionIma.Text = "Vista Previa Imagen";
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(ldldescripcionIma);
            Controls.Add(btnImagenesLocales);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(pbxAgregar);
            Controls.Add(lblImpresion);
            Controls.Add(cbxImpresion);
            Controls.Add(cbxEstilo);
            Controls.Add(lblEstilo);
            Controls.Add(lblImagen);
            Controls.Add(nudCanciones);
            Controls.Add(txtImgen);
            Controls.Add(lblCantidaCan);
            Controls.Add(dtpLanzamiento);
            Controls.Add(lblFecha);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregar";
            Load += frmAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)nudCanciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblFecha;
        private DateTimePicker dtpLanzamiento;
        private Label lblCantidaCan;
        private TextBox txtImgen;
        private NumericUpDown nudCanciones;
        private Label lblImagen;
        private Label lblEstilo;
        private ComboBox cbxEstilo;
        private ComboBox cbxImpresion;
        private Label lblImpresion;
        private PictureBox pbxAgregar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnImagenesLocales;
        private Label ldldescripcionIma;
    }
}