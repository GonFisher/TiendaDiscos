namespace VentanasDiscos
{
    partial class frmImpresion
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
            dgvListaImpresion = new DataGridView();
            pbxImpresion = new PictureBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaImpresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImpresion).BeginInit();
            SuspendLayout();
            // 
            // dgvListaImpresion
            // 
            dgvListaImpresion.AllowUserToAddRows = false;
            dgvListaImpresion.AllowUserToDeleteRows = false;
            dgvListaImpresion.AllowUserToResizeColumns = false;
            dgvListaImpresion.AllowUserToResizeRows = false;
            dgvListaImpresion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaImpresion.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListaImpresion.Location = new Point(26, 61);
            dgvListaImpresion.MultiSelect = false;
            dgvListaImpresion.Name = "dgvListaImpresion";
            dgvListaImpresion.ReadOnly = true;
            dgvListaImpresion.RowTemplate.Height = 25;
            dgvListaImpresion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaImpresion.Size = new Size(308, 234);
            dgvListaImpresion.TabIndex = 0;
            dgvListaImpresion.SelectionChanged += dgvListaImpresion_SelectionChanged;
            // 
            // pbxImpresion
            // 
            pbxImpresion.Location = new Point(426, 61);
            pbxImpresion.Name = "pbxImpresion";
            pbxImpresion.Size = new Size(337, 234);
            pbxImpresion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImpresion.TabIndex = 1;
            pbxImpresion.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(345, 354);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmImpresion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(pbxImpresion);
            Controls.Add(dgvListaImpresion);
            Name = "frmImpresion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tipos De Impresiones";
            Load += frmImpresion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaImpresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImpresion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaImpresion;
        private PictureBox pbxImpresion;
        private Button btnVolver;
    }
}