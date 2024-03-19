namespace VentanasDiscos
{
    partial class frmEstilos
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
            components = new System.ComponentModel.Container();
            dgvEstilos = new DataGridView();
            estiloBindingSource = new BindingSource(components);
            fontDialog1 = new FontDialog();
            btnVolver = new Button();
            lblHIstoria = new Label();
            pbxEstilos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estiloBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxEstilos).BeginInit();
            SuspendLayout();
            // 
            // dgvEstilos
            // 
            dgvEstilos.AllowUserToAddRows = false;
            dgvEstilos.AllowUserToDeleteRows = false;
            dgvEstilos.AllowUserToResizeColumns = false;
            dgvEstilos.AllowUserToResizeRows = false;
            dgvEstilos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstilos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEstilos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstilos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEstilos.Location = new Point(55, 41);
            dgvEstilos.MultiSelect = false;
            dgvEstilos.Name = "dgvEstilos";
            dgvEstilos.ReadOnly = true;
            dgvEstilos.RowTemplate.Height = 25;
            dgvEstilos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstilos.Size = new Size(438, 200);
            dgvEstilos.TabIndex = 1;
            dgvEstilos.SelectionChanged += dgvEstilos_SelectionChanged;
            // 
            // estiloBindingSource
            // 
            estiloBindingSource.DataSource = typeof(Arquetipo.Estilo);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(227, 414);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblHIstoria
            // 
            lblHIstoria.AutoSize = true;
            lblHIstoria.Font = new Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHIstoria.Location = new Point(115, 256);
            lblHIstoria.Name = "lblHIstoria";
            lblHIstoria.Size = new Size(266, 27);
            lblHIstoria.TabIndex = 3;
            lblHIstoria.Text = "Agrandar el Cuadro Para Leer la Historia";
            // 
            // pbxEstilos
            // 
            pbxEstilos.Location = new Point(193, 286);
            pbxEstilos.Name = "pbxEstilos";
            pbxEstilos.Size = new Size(145, 102);
            pbxEstilos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxEstilos.TabIndex = 4;
            pbxEstilos.TabStop = false;
            // 
            // frmEstilos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 449);
            Controls.Add(pbxEstilos);
            Controls.Add(lblHIstoria);
            Controls.Add(btnVolver);
            Controls.Add(dgvEstilos);
            Name = "frmEstilos";
            Text = "Estilos";
            Load += frmEstilos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)estiloBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxEstilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvEstilos;
        private BindingSource estiloBindingSource;
        private FontDialog fontDialog1;
        private Button btnVolver;
        private Label lblHIstoria;
        private PictureBox pictureBox1;
        private PictureBox pbxEstilos;
    }
}