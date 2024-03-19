namespace VentanasDiscos
{
    partial class frmDiscos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvListaDiscos = new DataGridView();
            pbxListaDiscos = new PictureBox();
            imageList1 = new ImageList(components);
            openFileDialog1 = new OpenFileDialog();
            btnVentanaEstilos = new Button();
            btnVentanaImpresion = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtFiltrar = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            button1 = new Button();
            cbxCampo = new ComboBox();
            cboCriterio = new ComboBox();
            txtBusqueda = new TextBox();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblParametro = new Label();
            btnBusqueda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaDiscos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxListaDiscos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaDiscos
            // 
            dgvListaDiscos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDiscos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListaDiscos.Location = new Point(3, 40);
            dgvListaDiscos.MultiSelect = false;
            dgvListaDiscos.Name = "dgvListaDiscos";
            dgvListaDiscos.RowTemplate.Height = 25;
            dgvListaDiscos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDiscos.Size = new Size(596, 252);
            dgvListaDiscos.TabIndex = 0;
            dgvListaDiscos.SelectionChanged += dgvListaDiscos_SelectionChanged;
            // 
            // pbxListaDiscos
            // 
            pbxListaDiscos.Location = new Point(681, 40);
            pbxListaDiscos.Name = "pbxListaDiscos";
            pbxListaDiscos.Size = new Size(206, 252);
            pbxListaDiscos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxListaDiscos.TabIndex = 1;
            pbxListaDiscos.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVentanaEstilos
            // 
            btnVentanaEstilos.Location = new Point(410, 12);
            btnVentanaEstilos.Name = "btnVentanaEstilos";
            btnVentanaEstilos.Size = new Size(71, 23);
            btnVentanaEstilos.TabIndex = 2;
            btnVentanaEstilos.Text = "Estilos";
            btnVentanaEstilos.UseVisualStyleBackColor = true;
            btnVentanaEstilos.Click += btnVentanaEstilos_Click;
            // 
            // btnVentanaImpresion
            // 
            btnVentanaImpresion.Location = new Point(487, 11);
            btnVentanaImpresion.Name = "btnVentanaImpresion";
            btnVentanaImpresion.Size = new Size(73, 23);
            btnVentanaImpresion.TabIndex = 3;
            btnVentanaImpresion.Text = "Impresion";
            btnVentanaImpresion.UseVisualStyleBackColor = true;
            btnVentanaImpresion.Click += btnVentanaImpresion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 298);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(93, 298);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(52, 13);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(278, 23);
            txtFiltrar.TabIndex = 6;
            txtFiltrar.TextChanged += txtFiltrar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Filtro";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(186, 298);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(605, 40);
            button1.Name = "button1";
            button1.Size = new Size(70, 45);
            button1.TabIndex = 9;
            button1.Text = "Recargar LIsta";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbxCampo
            // 
            cbxCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCampo.FormattingEnabled = true;
            cbxCampo.Location = new Point(3, 365);
            cbxCampo.Name = "cbxCampo";
            cbxCampo.Size = new Size(143, 23);
            cbxCampo.TabIndex = 10;
            cbxCampo.SelectedIndexChanged += cbxCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(167, 365);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(121, 23);
            cboCriterio.TabIndex = 11;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(294, 365);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(144, 23);
            txtBusqueda.TabIndex = 12;
           
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCampo.Location = new Point(40, 347);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(47, 15);
            lblCampo.TabIndex = 0;
            lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCriterio.Location = new Point(186, 347);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(51, 15);
            lblCriterio.TabIndex = 1;
            lblCriterio.Text = "Criterio";
            // 
            // lblParametro
            // 
            lblParametro.AutoSize = true;
            lblParametro.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblParametro.Location = new Point(320, 347);
            lblParametro.Name = "lblParametro";
            lblParametro.Size = new Size(68, 15);
            lblParametro.TabIndex = 2;
            lblParametro.Text = "Parametro";
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(444, 365);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(75, 23);
            btnBusqueda.TabIndex = 13;
            btnBusqueda.Text = "Busqueda";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // frmDiscos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(btnBusqueda);
            Controls.Add(lblParametro);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(txtBusqueda);
            Controls.Add(cboCriterio);
            Controls.Add(cbxCampo);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(txtFiltrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnVentanaImpresion);
            Controls.Add(btnVentanaEstilos);
            Controls.Add(pbxListaDiscos);
            Controls.Add(dgvListaDiscos);
            ForeColor = Color.Black;
            Name = "frmDiscos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Discos";
            Load += frmDiscos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaDiscos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxListaDiscos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaDiscos;
        private PictureBox pbxListaDiscos;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
        private Button btnVentanaEstilos;
        private Button btnVentanaImpresion;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtFiltrar;
        private Label label1;
        private Button btnEliminar;
        private Button button1;
        private ComboBox cbxCampo;
        private ComboBox cboCriterio;
        private TextBox txtBusqueda;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblParametro;
        private Button btnBusqueda;
    }
}
